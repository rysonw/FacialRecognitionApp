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

namespace FacialRecognition
{
    public partial class Form1 : Form
    {

        //Variables
        private Capture vidCapture = null; //Declare a new Capture Object
        private Image<Bgr, Byte> currentFrame = null;
        private bool faceDetectionEnabled = false;

        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");
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
                //Convert gr Image to a Gray Image
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(grayImage, grayImage); //Enhancing Image for easier recognition

                Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

                //Detect Faces
                if (faces.Length > 0)
                {
                    foreach(var face in faces)
                    {
                        //Draw Rectangle around the faces
                        CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 3);

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
    }
}
