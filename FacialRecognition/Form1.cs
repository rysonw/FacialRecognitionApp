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
using Google.Cloud.Vision.V1;
using Newtonsoft.Json;

namespace FacialRecognition
{
    public partial class Form1 : Form
    {

        #region Global Variables

        private Capture vidCapture = null; //Declare a new Capture Object
        private Image<Bgr, Byte> currentFrame = null; //Bgr is a color scheme, OpenCV uses BGR as their default. Here we are creating an image and defining that it will be in Bgr and represented as bytes
        private bool faceDetectionEnabled = false;
        //private string cascadeFileLocation = ""
        public string currentPhotoPath = "";

        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
        List<string> PersonsNames = new List<string>();
        bool enableSaveImage = false;
        bool isTrained = false;
        public string pathTrain = Directory.GetCurrentDirectory() + @"\Train_Images"; //Change direvtory for saving images here 

        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("C:\\Users\\wongr\\OneDrive\\Desktop\\CS_Projects\\FaceRecog\\FacialRecognition\\haarcascade_frontalface_default.xml"); //Declaring Capture Rectangle; Static for now will add secret later
        Mat frame = new Mat();
        EigenFaceRecognizer recognizer;

        #endregion


        public Form1()
        {
            InitializeComponent();
            vidCapture = new Capture();
            vidCapture.ImageGrabbed += ProcessFrame;
            vidCapture.Start();
        }

        //private void CaptureButton_Click(object sender, EventArgs e)
        //{
        //    vidCapture = new Capture();
        //    vidCapture.ImageGrabbed += ProcessFrame;
        //    vidCapture.Start();
                
        //}

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
                    foreach(var face in faces)
                    {
                        // Draw Rectangle around the faces
                        // CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 3);

                        //Step 3: Add Person
                        Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                        resultImage.ROI = face;
                        SamplePictureBox.SizeMode = PictureBoxSizeMode.StretchImage; //Resizing capture to fit in mini capture box on the left
                        SamplePictureBox.Image = resultImage.Bitmap;

                        if (enableSaveImage)
                        {

                            if (!Directory.Exists(pathTrain)) //We create this directory if it does not exist 
                            {
                                Directory.CreateDirectory(pathTrain);
                            }
                            ////Tasks are basically threads; Is this thread needed if we are only taking one picture?; Google Cloud API implementation starts here. Have it save image to directory then send to Google for classification
                            Task.Factory.StartNew(() => {
                                for (int i = 0; i < 10; i++)
                                {
                                    //resize the image then saving it
                                    resultImage.Resize(200, 200, Inter.Cubic).Save(pathTrain + @"\" + textPersonName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                    Thread.Sleep(1000);
                                }
                            });
                            ////TODO: Should I wipe this directory before making the sending out the request?
                            //var client = ImageAnnotatorClient.Create();

                            //resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + textPersonName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy") + ".jpg");

                            ////Load recently saved image into memory
                            //var sentImage = Google.Cloud.Vision.V1.Image.FromFile(path + @"\" + textPersonName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy") + ".jpg");

                            ////Perform label detection on image file; here we are saving the JSON response
                            //var response = client.DetectLabels(sentImage);

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
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                Debug.WriteLine(result.Label + ". " + result.Distance);
                                
                                //Here results found known faces
                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Blue).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 3);
                                }
                                //here results did not found any know faces
                                else
                                {
                                    CvInvoke.PutText(currentFrame, "????", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Red).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 3);

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
            SaveAndSendButton.Enabled = true;
            AddPersonButton.Enabled = true;
            enableSaveImage = true;
        }

        private void SaveAndSendButton_Click(object sender, EventArgs e)
        { 
            SaveAndSendButton.Enabled = false;
            AddPersonButton.Enabled = true;
            enableSaveImage = false;

            var client = ImageAnnotatorClient.Create();
            var image = Google.Cloud.Vision.V1.Image.FromFile("Sample Images\\happy.jfif"); //How to save image and send it to Google Cloud API; Create stats??
            var response = client.DetectFaces(image).ToString(); //JSON response

            //System.Diagnostics.Debug.Write(response.ToString());

            dynamic dynJson = JsonConvert.DeserializeObject(response);

            //Displayin JSON in respective fields
            confidenceOutput.Text = $"Detection Confidence: {(dynJson[0]["detectionConfidence"].ToDouble() * 100).ToString()}%";
            joyOutput.Text = $"Joy: {dynJson[0]["joyLikelihood"].ToString()}";
            sorrowOutput.Text = $"Sorrow: {dynJson[0]["sorrowLikelihood"].ToString()}";
            angerOutput.Text = $"Anger: {dynJson[0]["angerLikelihood"].ToString()}";
            surpriseOutput.Text = $"Surpise: {dynJson[0]["surpriseLikelihood"].ToString()}";

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
                if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Trained_Faces")) //We create this directory if it does not exist 
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Trained_Faces");
                }

                string pathTrained = Directory.GetCurrentDirectory() + @"\Trained_Faces";

                string[] files = Directory.GetFiles(pathTrained, "*.jpg", SearchOption.AllDirectories); //Creating array of all files

                foreach (var file in files)
                {
                    Image<Gray, Byte> trainedImage = new Image<Gray, byte>(file);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(imageCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    imageCount++;
                    Debug.WriteLine(imageCount + ". " + name);
                }

                if (TrainedFaces.Count() > 0)
                {
                    // recognizer = new EigenFaceRecognizer(ImagesCount,Threshold);
                    recognizer = new EigenFaceRecognizer(imageCount, threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());
                    isTrained = true;
                    Debug.WriteLine(imageCount);
                    //Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }

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
