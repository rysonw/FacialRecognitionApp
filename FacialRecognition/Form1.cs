#region Imports

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
using System.Windows.Forms.VisualStyles;

#endregion

//gcloud auth application-default login

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

        //Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
        List<string> PersonsNames = new List<string>();
        bool enableSaveImage = false;
        bool isTrained = false;

        public string pathTrain = Directory.GetCurrentDirectory() + @"\Train_Images"; //Change directory for saving images for training
        public string pathToSend = Directory.GetCurrentDirectory() + @"\Send_Images"; //Directory for saving images to send to Google Cloud Vision
        public string pathToFace;
        DirectoryInfo dirToSend = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\Send_Images");

        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("C:\\Users\\ryson\\source\\repos\\FacialRecognition\\FacialRecognition\\haarcascade_frontalface_default.xml"); //Declaring Capture Rectangle; Static for now will add secret later
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


        private void ProcessFrame(object sender, EventArgs e) //Handles ProcessFrame which will be rendered into picture box
        {
            //Step 1: Capture the Video and render it into main picture box
            vidCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic); //Main Picture Box

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

                            if (!Directory.Exists(pathToSend)) //We create this directory if it does not exist 
                            {
                                Directory.CreateDirectory(pathToSend);
                            }

                            //Tasks are basically threads; they are used to run multiple processes at the same time
                            Task.Factory.StartNew(() => {
                                for (int i = 0; i < 10; i++)
                                {
                                    //resize the image then saving it
                                    resultImage.Resize(200, 200, Inter.Cubic).Save(pathTrain + @"\" + textPersonName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                    Thread.Sleep(1000);
                                }
                            });



                            if (dirToSend.GetDirectories() == null) //Checking to see if pathSending Directory is empty
                            {
                                continue;
                            }
                            else
                            {
                                FileInfo[] files = dirToSend.GetFiles();
                                foreach (FileInfo file in files)
                                {
                                    file.Delete();
                                }
                            }

                            enableSaveImage = false;

                            resultImage.Resize(200, 200, Inter.Cubic).Save(pathToSend + @"\" + textPersonName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                            pathToFace = pathToSend + @"\" + textPersonName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg";

                            if (AddPersonButton.InvokeRequired) //Make sure you are interacting with the right element in the correct thread
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
                                
                                //Results found known faces;
                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Blue).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 3);
                                }
                                //Results did not found any know faces
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
            //Step 2: Facial Recognition while capturing video; NEEDS TO BE CLICKED BEFORE ADD PERSON or ERROR
            faceDetectionEnabled = true;
        }

        //Wrap function in try catch block 
        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            moodChart.Series["Moods"].Points.Clear(); //Clear charts

            SaveToTrain.Enabled = true;
            AddPersonButton.Enabled = true;
            enableSaveImage = true;

            var client = ImageAnnotatorClient.Create();
            var image = Google.Cloud.Vision.V1.Image.FromFile(pathToFace); //Save image and send it to Google Cloud Vision API
            var response = client.DetectFaces(image).ToString(); //JSON response
            
            Thread.Sleep(2000);
            dynamic dynJson = JsonConvert.DeserializeObject(response);
            Thread.Sleep(2000);

            //TODO: Create a one-liner for this code; NEED TRY CATCH BLOCK IF PICTURE IS TAKEN W/O FACE

            double confidence = Convert.ToDouble((dynJson[0]["detectionConfidence"]) * 100);
            string confidenceString = confidence.ToString();
            string splicedConfidenceString = confidenceString.Substring(0, 5);

            string confidenceO = $"{splicedConfidenceString}%";
            string joyO = $"{dynJson[0]["joyLikelihood"].ToString()}";
            string sorrowO = $"{dynJson[0]["sorrowLikelihood"].ToString()}";
            string angerO = $"{dynJson[0]["angerLikelihood"].ToString()}";
            string surpriseO = $"{dynJson[0]["surpriseLikelihood"].ToString()}";

            confidenceOutput.Text = confidenceO;
            joyOutput.Text = joyO;
            sorrowOutput.Text = sorrowO;
            angerOutput.Text = angerO;
            surpriseOutput.Text = surpriseO;

            string[] moodStrings = new string[] { joyO, sorrowO, angerO, surpriseO };
            Dictionary<string, int> moodPercentages = new Dictionary<string, int>(); //Dictionary to hold the mood results; Name of Mood: Percentage in Graph


            for (int i = 0; i < 4; i++) //Use index to identify what mood; Getting error trying to use a switch
            {
                if (i == 0)
                {
                    if (moodStrings[i] == "VERY_UNLIKELY" || moodStrings[i] == "UNLIKELY")
                    {
                        moodPercentages.Add("Joy", 0);
                    }

                    else if (moodStrings[i] == "LIKELY")
                    {
                        moodPercentages.Add("Joy", 10);
                    }

                    else //VERY_LIKELY
                    {
                        moodPercentages.Add("Joy", 80);
                    }
                }

                if (i == 1)
                {
                    if (moodStrings[i] == "VERY_UNLIKELY" || moodStrings[i] == "UNLIKELY")
                    {
                        moodPercentages.Add("Sorrow", 0);
                    }

                    else if (moodStrings[i] == "LIKELY")
                    {
                        moodPercentages.Add("Sorrow", 10);
                    }

                    else //VERY_LIKELY
                    {
                        moodPercentages.Add("Sorrow", 80);
                    }
                }

                if (i == 2)
                {
                    if (moodStrings[i] == "VERY_UNLIKELY" || moodStrings[i] == "UNLIKELY")
                    {
                        moodPercentages.Add("Anger", 0);
                    }

                    else if (moodStrings[i] == "LIKELY")
                    {
                        moodPercentages.Add("Anger", 10);
                    }

                    else //VERY_LIKELY
                    {
                        moodPercentages.Add("Anger", 80);
                    }
                }

                if (i == 3)
                {
                    if (moodStrings[i] == "VERY_UNLIKELY" || moodStrings[i] == "UNLIKELY")
                    {
                        moodPercentages.Add("Surprised", 0);
                    }

                    else if (moodStrings[i] == "LIKELY")
                    {
                        moodPercentages.Add("Surprised", 10);
                    }

                    else //VERY_LIKELY
                    {
                        moodPercentages.Add("Surprised", 80);
                    }
                }
            }

            int counter = 0;

            foreach (string mood in moodPercentages.Keys)
            {
                if (moodPercentages[mood] == 0)
                {
                    counter++;
                }

                //moodChart.Series["Moods"].Points.AddXY(mood, moodPercentages[mood]);
            }

            if (counter == 4)
            {
                moodChart.Series["Moods"].Points.AddXY("Neutral", 100);
            }

            else
            {
                foreach (string mood in moodPercentages.Keys)
                {
                    if (moodPercentages[mood] == 0)
                    {
                        continue;
                    }
                    else { 
                    moodChart.Series["Moods"].Points.AddXY(mood, moodPercentages[mood]);
                    }
                }
            }
                
        }
        
        private void SaveToTrain_Click(object sender, EventArgs e)
        { 
            SaveToTrain.Enabled = true;
            AddPersonButton.Enabled = true;
            enableSaveImage = true;


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
                    recognizer = new EigenFaceRecognizer(imageCount, threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());
                    isTrained = true;
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
