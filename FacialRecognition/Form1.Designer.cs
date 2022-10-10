namespace FacialRecognition
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.CaptureButton = new System.Windows.Forms.Button();
            this.DetectButton = new System.Windows.Forms.Button();
            this.textPersonName = new System.Windows.Forms.TextBox();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.TrainButton = new System.Windows.Forms.Button();
            this.recognizeButton = new System.Windows.Forms.Button();
            this.SamplePictureBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(10, 10);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(634, 432);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // CaptureButton
            // 
            this.CaptureButton.Location = new System.Drawing.Point(659, 16);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.Size = new System.Drawing.Size(127, 27);
            this.CaptureButton.TabIndex = 1;
            this.CaptureButton.Text = "Capture Image";
            this.CaptureButton.UseVisualStyleBackColor = true;
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // DetectButton
            // 
            this.DetectButton.Location = new System.Drawing.Point(659, 49);
            this.DetectButton.Name = "DetectButton";
            this.DetectButton.Size = new System.Drawing.Size(127, 27);
            this.DetectButton.TabIndex = 2;
            this.DetectButton.Text = "Detect Faces";
            this.DetectButton.UseVisualStyleBackColor = true;
            this.DetectButton.Click += new System.EventHandler(this.DetectButton_Click);
            // 
            // textPersonName
            // 
            this.textPersonName.Location = new System.Drawing.Point(659, 234);
            this.textPersonName.Name = "textPersonName";
            this.textPersonName.Size = new System.Drawing.Size(127, 20);
            this.textPersonName.TabIndex = 3;
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(659, 82);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(127, 23);
            this.AddPersonButton.TabIndex = 4;
            this.AddPersonButton.Text = "Add Person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(659, 372);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(127, 24);
            this.TrainButton.TabIndex = 5;
            this.TrainButton.Text = "Train Images";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // recognizeButton
            // 
            this.recognizeButton.Location = new System.Drawing.Point(659, 402);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(127, 23);
            this.recognizeButton.TabIndex = 6;
            this.recognizeButton.Text = "Recognize";
            this.recognizeButton.UseVisualStyleBackColor = true;
            // 
            // SamplePictureBox
            // 
            this.SamplePictureBox.Location = new System.Drawing.Point(659, 111);
            this.SamplePictureBox.Name = "SamplePictureBox";
            this.SamplePictureBox.Size = new System.Drawing.Size(127, 117);
            this.SamplePictureBox.TabIndex = 7;
            this.SamplePictureBox.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(659, 343);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(659, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(659, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SamplePictureBox);
            this.Controls.Add(this.recognizeButton);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.textPersonName);
            this.Controls.Add(this.DetectButton);
            this.Controls.Add(this.CaptureButton);
            this.Controls.Add(this.picCapture);
            this.Name = "Form1";
            this.Text = "Facial Recognition App";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button CaptureButton;
        private System.Windows.Forms.Button DetectButton;
        private System.Windows.Forms.TextBox textPersonName;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Button recognizeButton;
        private System.Windows.Forms.PictureBox SamplePictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

