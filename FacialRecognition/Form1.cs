using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Drawing.Text;
using System.Diagnostics;

namespace FacialRecognition
{
    public partial class Form1 : Form
    {

        #region Global Variables

        private Capture vidCapture = null; //Declare a new Capture Object
        private Image<Bgr, Byte> currentFrame = null; //Bgr is a color scheme, OpenCV uses BGR as their default. Here we are creating an image and defining that it will be in Bgr and represented as bytes
        private bool faceDetectionEnabled = false;
        //private string cascadeFileLocation = ""

        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
        List<string> PersonsNames = new List<string>();
        bool enableSaveImage = false;
        bool isTrained = false;

        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml"); //Declaring Capture Rectangle
        Mat frame = new Mat();
        EigenFaceRecognizer recognizer;

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            vidCapture = new Capture();
            vidCapture.ImageGrabbed += ProcessFrame;
            vidCapture.Start();
                
        }

        private void ProcessFrame(object sender, EventArgs e) //Handles ProcessFrame which will be rendered into picture box
        {
            //Step 1: Capture the Video and render it into main picture box
            vidCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);

            //Step 2: Facial Recognition while capturing video
            if (faceDetectionEnabled)
            {
                //Convert Bgr Image to a Gray Image
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(grayImage, grayImage); //Enhancing Image for easier recognition

                Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

                //Detect Faces
                if (faces.Length > 0)
                {
                    //int faceId = 0;
                    foreach(var face in faces)
                    {
                        //Draw Rectangle around the faces
                        // CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 3);

                        //Step 3: Add Person
                        Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                        resultImage.ROI = face;
                        SamplePictureBox.SizeMode = PictureBoxSizeMode.StretchImage; //Resizing capture to fit in mini capture box on the left
                        SamplePictureBox.Image = resultImage.Bitmap;

                        if (enableSaveImage)
                        {
                            string path = Directory.GetCurrentDirectory() + @"\Train_Images"; //Change direvtory for saving images here 

                            if (!Directory.Exists(path)) //We create this directory if it does not exist 
                            {
                                Directory.CreateDirectory(path);
                            }

                            Task.Factory.StartNew(() => //Tasks are basically threads
                            {
                                for (int i = 0; i < 10; i++)
                                {
                                    //Resizing the image and then saving it the directory above
                                    resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + textPersonName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                    Thread.Sleep(1000);
                                }

                            });
                            enableSaveImage = false;


                            if (AddPersonButton.InvokeRequired) //Invokes make sure you are interacting with the right element in the correct thread
                            {
                                AddPersonButton.Invoke(new ThreadStart(delegate
                                {
                                    AddPersonButton.Enabled = true;
                                }));
                            }

                            //Step 5: Recognize Known Faces
                            if (isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);

                                var result = recognizer.Predict(grayFaceResult);

                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(currentFrame, "???", new Point(face.X - 2, face.Y - 2), FontFace.HersheyTriplex, 1.0, new Bgr(Color.Red).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 3);
                                }
                                //If faces seen are not known
                                else
                                {
                                    CvInvoke.PutText(currentFrame, "???", new Point(face.X - 2, face.Y - 2), FontFace.HersheyTriplex, 1.0, new Bgr(Color.Red).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 3);
                                }
                            }

                        }


                    }                
                }
            }

            picCapture.Image = currentFrame.Bitmap;

        }

        private void DetectButton_Click(object sender, EventArgs e)
        {
            //Step 2: Facial Recognition while capturing video
            faceDetectionEnabled = true;
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;
            AddPersonButton.Enabled = true;
            enableSaveImage = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = false;
            AddPersonButton.Enabled = true;
            enableSaveImage = false;

        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            TrainImagesFromDirectory();
        }

        private bool TrainImagesFromDirectory()
        {
            int imageCount = 0;
            double threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();

            try
            {
                string path = Directory.GetCurrentDirectory() + @"\Trained_Faces";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories); //Creating array of all files

                foreach (var file in files)
                {
                    Image<Gray, Byte> trainedImage = new Image<Gray, byte>(file);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(imageCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    imageCount++;
                    Debug.WriteLine(imageCount + ". " + name);
                    imageCount++;
                }

                EigenFaceRecognizer recognizer = new EigenFaceRecognizer(imageCount, threshold);
                recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());

                isTrained = true;
                return true;

            }

            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + ex.Message);
                return false;
            }
        }

    }
}
