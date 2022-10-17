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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.DetectButton = new System.Windows.Forms.Button();
            this.textPersonName = new System.Windows.Forms.TextBox();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.TrainButton = new System.Windows.Forms.Button();
            this.recognizeButton = new System.Windows.Forms.Button();
            this.SamplePictureBox = new System.Windows.Forms.PictureBox();
            this.SaveAndSendButton = new System.Windows.Forms.Button();
            this.moodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.confidenceLabel = new System.Windows.Forms.Label();
            this.supriseLabel = new System.Windows.Forms.Label();
            this.angerLabel = new System.Windows.Forms.Label();
            this.sorrowLabel = new System.Windows.Forms.Label();
            this.joyLabel = new System.Windows.Forms.Label();
            this.surpriseOutput = new System.Windows.Forms.TextBox();
            this.confidenceOutput = new System.Windows.Forms.TextBox();
            this.joyOutput = new System.Windows.Forms.TextBox();
            this.sorrowOutput = new System.Windows.Forms.TextBox();
            this.angerOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moodChart)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(10, 10);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(634, 510);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // DetectButton
            // 
            this.DetectButton.Location = new System.Drawing.Point(659, 12);
            this.DetectButton.Name = "DetectButton";
            this.DetectButton.Size = new System.Drawing.Size(127, 27);
            this.DetectButton.TabIndex = 2;
            this.DetectButton.Text = "Detect Faces";
            this.DetectButton.UseVisualStyleBackColor = true;
            this.DetectButton.Click += new System.EventHandler(this.DetectButton_Click);
            // 
            // textPersonName
            // 
            this.textPersonName.Location = new System.Drawing.Point(659, 197);
            this.textPersonName.Name = "textPersonName";
            this.textPersonName.Size = new System.Drawing.Size(127, 20);
            this.textPersonName.TabIndex = 3;
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(659, 45);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(127, 23);
            this.AddPersonButton.TabIndex = 4;
            this.AddPersonButton.Text = "Add Person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(659, 255);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(127, 26);
            this.TrainButton.TabIndex = 5;
            this.TrainButton.Text = "Train Images";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // recognizeButton
            // 
            this.recognizeButton.Location = new System.Drawing.Point(659, 287);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(127, 25);
            this.recognizeButton.TabIndex = 6;
            this.recognizeButton.Text = "Recognize";
            this.recognizeButton.UseVisualStyleBackColor = true;
            // 
            // SamplePictureBox
            // 
            this.SamplePictureBox.Location = new System.Drawing.Point(659, 74);
            this.SamplePictureBox.Name = "SamplePictureBox";
            this.SamplePictureBox.Size = new System.Drawing.Size(127, 117);
            this.SamplePictureBox.TabIndex = 7;
            this.SamplePictureBox.TabStop = false;
            // 
            // SaveAndSendButton
            // 
            this.SaveAndSendButton.Location = new System.Drawing.Point(659, 224);
            this.SaveAndSendButton.Name = "SaveAndSendButton";
            this.SaveAndSendButton.Size = new System.Drawing.Size(127, 25);
            this.SaveAndSendButton.TabIndex = 8;
            this.SaveAndSendButton.Text = "Save and Evaluate";
            this.SaveAndSendButton.UseVisualStyleBackColor = true;
            this.SaveAndSendButton.Click += new System.EventHandler(this.SaveAndSendButton_Click);
            // 
            // moodChart
            // 
            chartArea2.Name = "ChartArea1";
            this.moodChart.ChartAreas.Add(chartArea2);
            this.moodChart.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            legend2.Name = "Legend1";
            this.moodChart.Legends.Add(legend2);
            this.moodChart.Location = new System.Drawing.Point(659, 335);
            this.moodChart.Name = "moodChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.moodChart.Series.Add(series2);
            this.moodChart.Size = new System.Drawing.Size(269, 185);
            this.moodChart.TabIndex = 9;
            this.moodChart.Text = "Mood Chart";
            // 
            // confidenceLabel
            // 
            this.confidenceLabel.AutoSize = true;
            this.confidenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confidenceLabel.Location = new System.Drawing.Point(792, 19);
            this.confidenceLabel.Name = "confidenceLabel";
            this.confidenceLabel.Size = new System.Drawing.Size(75, 13);
            this.confidenceLabel.TabIndex = 10;
            this.confidenceLabel.Text = "Confidence:";
            // 
            // supriseLabel
            // 
            this.supriseLabel.AutoSize = true;
            this.supriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supriseLabel.Location = new System.Drawing.Point(792, 146);
            this.supriseLabel.Name = "supriseLabel";
            this.supriseLabel.Size = new System.Drawing.Size(57, 13);
            this.supriseLabel.TabIndex = 11;
            this.supriseLabel.Text = "Surprise:";
            // 
            // angerLabel
            // 
            this.angerLabel.AutoSize = true;
            this.angerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angerLabel.Location = new System.Drawing.Point(792, 114);
            this.angerLabel.Name = "angerLabel";
            this.angerLabel.Size = new System.Drawing.Size(44, 13);
            this.angerLabel.TabIndex = 12;
            this.angerLabel.Text = "Anger:";
            // 
            // sorrowLabel
            // 
            this.sorrowLabel.AutoSize = true;
            this.sorrowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorrowLabel.Location = new System.Drawing.Point(792, 84);
            this.sorrowLabel.Name = "sorrowLabel";
            this.sorrowLabel.Size = new System.Drawing.Size(50, 13);
            this.sorrowLabel.TabIndex = 13;
            this.sorrowLabel.Text = "Sorrow:";
            // 
            // joyLabel
            // 
            this.joyLabel.AutoSize = true;
            this.joyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joyLabel.Location = new System.Drawing.Point(792, 50);
            this.joyLabel.Name = "joyLabel";
            this.joyLabel.Size = new System.Drawing.Size(30, 13);
            this.joyLabel.TabIndex = 14;
            this.joyLabel.Text = "Joy:";
            // 
            // surpriseOutput
            // 
            this.surpriseOutput.Location = new System.Drawing.Point(855, 143);
            this.surpriseOutput.Name = "surpriseOutput";
            this.surpriseOutput.Size = new System.Drawing.Size(72, 20);
            this.surpriseOutput.TabIndex = 15;
            // 
            // confidenceOutput
            // 
            this.confidenceOutput.Location = new System.Drawing.Point(873, 16);
            this.confidenceOutput.Name = "confidenceOutput";
            this.confidenceOutput.Size = new System.Drawing.Size(55, 20);
            this.confidenceOutput.TabIndex = 16;
            // 
            // joyOutput
            // 
            this.joyOutput.Location = new System.Drawing.Point(828, 50);
            this.joyOutput.Name = "joyOutput";
            this.joyOutput.Size = new System.Drawing.Size(99, 20);
            this.joyOutput.TabIndex = 17;
            // 
            // sorrowOutput
            // 
            this.sorrowOutput.Location = new System.Drawing.Point(848, 84);
            this.sorrowOutput.Name = "sorrowOutput";
            this.sorrowOutput.Size = new System.Drawing.Size(79, 20);
            this.sorrowOutput.TabIndex = 18;
            // 
            // angerOutput
            // 
            this.angerOutput.Location = new System.Drawing.Point(842, 114);
            this.angerOutput.Name = "angerOutput";
            this.angerOutput.Size = new System.Drawing.Size(85, 20);
            this.angerOutput.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(940, 532);
            this.Controls.Add(this.angerOutput);
            this.Controls.Add(this.sorrowOutput);
            this.Controls.Add(this.joyOutput);
            this.Controls.Add(this.confidenceOutput);
            this.Controls.Add(this.surpriseOutput);
            this.Controls.Add(this.joyLabel);
            this.Controls.Add(this.sorrowLabel);
            this.Controls.Add(this.angerLabel);
            this.Controls.Add(this.supriseLabel);
            this.Controls.Add(this.confidenceLabel);
            this.Controls.Add(this.moodChart);
            this.Controls.Add(this.SaveAndSendButton);
            this.Controls.Add(this.SamplePictureBox);
            this.Controls.Add(this.recognizeButton);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.textPersonName);
            this.Controls.Add(this.DetectButton);
            this.Controls.Add(this.picCapture);
            this.Name = "Form1";
            this.Text = "moodi.io";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moodChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button DetectButton;
        private System.Windows.Forms.TextBox textPersonName;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Button recognizeButton;
        private System.Windows.Forms.PictureBox SamplePictureBox;
        private System.Windows.Forms.Button SaveAndSendButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart moodChart;
        private System.Windows.Forms.Label confidenceLabel;
        private System.Windows.Forms.Label supriseLabel;
        private System.Windows.Forms.Label angerLabel;
        private System.Windows.Forms.Label sorrowLabel;
        private System.Windows.Forms.Label joyLabel;
        private System.Windows.Forms.TextBox surpriseOutput;
        private System.Windows.Forms.TextBox confidenceOutput;
        private System.Windows.Forms.TextBox joyOutput;
        private System.Windows.Forms.TextBox sorrowOutput;
        private System.Windows.Forms.TextBox angerOutput;
    }
}

