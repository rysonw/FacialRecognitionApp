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
            //Step 1: Capture the Video
            vidCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);

            //Render video into main picture box
            picCapture.Image = currentFrame.Bitmap;

        }
    }
}
