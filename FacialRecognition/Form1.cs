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

namespace FacialRecognition
{
    public partial class Form1 : Form
    {

        //Variables
        private Capture vidCapture = null; //Declare a new Capture Object
        private Image<Bgr, Byte> currentFrame = null; //Bgr is a color scheme, OpenCV uses BGR as their default. Here we are creating an image and defining that it will be in Bgr and represented as bytes
        private bool faceDetectionEnabled = false;
        //private string cascadeFileLocation = ""

        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
        bool enableSaveImage = false;
   

        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml"); //Declaring Capture Rectangle
        Mat frame = new Mat();


        public Form1()
        {
            InitializeComponent();
        }

        private void captureButton_Click(object sender, EventArgs e)
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
                    int faceId = 0;
                    foreach(var face in faces)
                    {
                        //Draw Rectangle around the faces
                        CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 3); //Change frames here

                        //Step 3: Add Person
                        Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                        resultImage.ROI = face;
                        samplePictureBox.SizeMode = PictureBoxSizeMode.StretchImage; //Resizing capture to fit in mini capture box on the left
                        samplePictureBox.Image = resultImage.Bitmap;

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
                        }


                    }                
                }
            }

            picCapture.Image = currentFrame.Bitmap;

        }

        private void detectButton_Click(object sender, EventArgs e)
        {
            //Step 2: Facial Recognition while capturing video
            faceDetectionEnabled = true;


        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
            addPersonButton.Enabled = true;
            enableSaveImage = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
            addPersonButton.Enabled = true;
            enableSaveImage = false;

        }
    }
}
