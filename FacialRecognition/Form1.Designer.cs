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
            this.captureButton = new System.Windows.Forms.Button();
            this.detectButton = new System.Windows.Forms.Button();
            this.textPersonName = new System.Windows.Forms.TextBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.trainButton = new System.Windows.Forms.Button();
            this.recognizeButton = new System.Windows.Forms.Button();
            this.samplePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplePictureBox)).BeginInit();
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
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(659, 16);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(127, 27);
            this.captureButton.TabIndex = 1;
            this.captureButton.Text = "Capture Image";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // detectButton
            // 
            this.detectButton.Location = new System.Drawing.Point(659, 60);
            this.detectButton.Name = "detectButton";
            this.detectButton.Size = new System.Drawing.Size(127, 27);
            this.detectButton.TabIndex = 2;
            this.detectButton.Text = "Detect Faces";
            this.detectButton.UseVisualStyleBackColor = true;
            this.detectButton.Click += new System.EventHandler(this.detectButton_Click);
            // 
            // textPersonName
            // 
            this.textPersonName.Location = new System.Drawing.Point(661, 217);
            this.textPersonName.Name = "textPersonName";
            this.textPersonName.Size = new System.Drawing.Size(127, 20);
            this.textPersonName.TabIndex = 3;
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(661, 244);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(127, 23);
            this.addPersonButton.TabIndex = 4;
            this.addPersonButton.Text = "Add Person";
            this.addPersonButton.UseVisualStyleBackColor = true;
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(661, 273);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(127, 24);
            this.trainButton.TabIndex = 5;
            this.trainButton.Text = "Train Images";
            this.trainButton.UseVisualStyleBackColor = true;
            // 
            // recognizeButton
            // 
            this.recognizeButton.Location = new System.Drawing.Point(661, 304);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(127, 23);
            this.recognizeButton.TabIndex = 6;
            this.recognizeButton.Text = "Recognize";
            this.recognizeButton.UseVisualStyleBackColor = true;
            // 
            // samplePictureBox
            // 
            this.samplePictureBox.Location = new System.Drawing.Point(659, 94);
            this.samplePictureBox.Name = "samplePictureBox";
            this.samplePictureBox.Size = new System.Drawing.Size(127, 117);
            this.samplePictureBox.TabIndex = 7;
            this.samplePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.samplePictureBox);
            this.Controls.Add(this.recognizeButton);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.textPersonName);
            this.Controls.Add(this.detectButton);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.picCapture);
            this.Name = "Form1";
            this.Text = "Facial Recognition App";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button detectButton;
        private System.Windows.Forms.TextBox textPersonName;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button recognizeButton;
        private System.Windows.Forms.PictureBox samplePictureBox;
    }
}

