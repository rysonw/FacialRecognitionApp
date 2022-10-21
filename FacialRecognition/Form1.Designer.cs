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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.picCapture.Location = new System.Drawing.Point(20, 20);
            this.picCapture.Margin = new System.Windows.Forms.Padding(6);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(1268, 1020);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // DetectButton
            // 
            this.DetectButton.Location = new System.Drawing.Point(1318, 24);
            this.DetectButton.Margin = new System.Windows.Forms.Padding(6);
            this.DetectButton.Name = "DetectButton";
            this.DetectButton.Size = new System.Drawing.Size(254, 54);
            this.DetectButton.TabIndex = 2;
            this.DetectButton.Text = "Detect Faces";
            this.DetectButton.UseVisualStyleBackColor = true;
            this.DetectButton.Click += new System.EventHandler(this.DetectButton_Click);
            // 
            // textPersonName
            // 
            this.textPersonName.Location = new System.Drawing.Point(1318, 394);
            this.textPersonName.Margin = new System.Windows.Forms.Padding(6);
            this.textPersonName.Name = "textPersonName";
            this.textPersonName.Size = new System.Drawing.Size(250, 31);
            this.textPersonName.TabIndex = 3;
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(1318, 90);
            this.AddPersonButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(254, 46);
            this.AddPersonButton.TabIndex = 4;
            this.AddPersonButton.Text = "Add Person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(1318, 510);
            this.TrainButton.Margin = new System.Windows.Forms.Padding(6);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(254, 52);
            this.TrainButton.TabIndex = 5;
            this.TrainButton.Text = "Train Images";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // recognizeButton
            // 
            this.recognizeButton.Location = new System.Drawing.Point(1318, 574);
            this.recognizeButton.Margin = new System.Windows.Forms.Padding(6);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(254, 50);
            this.recognizeButton.TabIndex = 6;
            this.recognizeButton.Text = "Recognize";
            this.recognizeButton.UseVisualStyleBackColor = true;
            // 
            // SamplePictureBox
            // 
            this.SamplePictureBox.Location = new System.Drawing.Point(1318, 148);
            this.SamplePictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.SamplePictureBox.Name = "SamplePictureBox";
            this.SamplePictureBox.Size = new System.Drawing.Size(254, 234);
            this.SamplePictureBox.TabIndex = 7;
            this.SamplePictureBox.TabStop = false;
            // 
            // SaveAndSendButton
            // 
            this.SaveAndSendButton.Location = new System.Drawing.Point(1318, 448);
            this.SaveAndSendButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveAndSendButton.Name = "SaveAndSendButton";
            this.SaveAndSendButton.Size = new System.Drawing.Size(254, 50);
            this.SaveAndSendButton.TabIndex = 8;
            this.SaveAndSendButton.Text = "Save and Evaluate";
            this.SaveAndSendButton.UseVisualStyleBackColor = true;
            this.SaveAndSendButton.Click += new System.EventHandler(this.SaveAndSendButton_Click);
            // 
            // moodChart
            // 
            chartArea1.Name = "ChartArea1";
            this.moodChart.ChartAreas.Add(chartArea1);
            this.moodChart.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            legend1.Name = "Legend1";
            this.moodChart.Legends.Add(legend1);
            this.moodChart.Location = new System.Drawing.Point(1318, 670);
            this.moodChart.Margin = new System.Windows.Forms.Padding(6);
            this.moodChart.Name = "moodChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Moods";
            this.moodChart.Series.Add(series1);
            this.moodChart.Size = new System.Drawing.Size(538, 370);
            this.moodChart.TabIndex = 9;
            this.moodChart.Text = "Mood Chart";
            // 
            // confidenceLabel
            // 
            this.confidenceLabel.AutoSize = true;
            this.confidenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confidenceLabel.Location = new System.Drawing.Point(1584, 38);
            this.confidenceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.confidenceLabel.Name = "confidenceLabel";
            this.confidenceLabel.Size = new System.Drawing.Size(139, 26);
            this.confidenceLabel.TabIndex = 10;
            this.confidenceLabel.Text = "Confidence:";
            // 
            // supriseLabel
            // 
            this.supriseLabel.AutoSize = true;
            this.supriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supriseLabel.Location = new System.Drawing.Point(1584, 292);
            this.supriseLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.supriseLabel.Name = "supriseLabel";
            this.supriseLabel.Size = new System.Drawing.Size(108, 26);
            this.supriseLabel.TabIndex = 11;
            this.supriseLabel.Text = "Surprise:";
            // 
            // angerLabel
            // 
            this.angerLabel.AutoSize = true;
            this.angerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angerLabel.Location = new System.Drawing.Point(1584, 228);
            this.angerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.angerLabel.Name = "angerLabel";
            this.angerLabel.Size = new System.Drawing.Size(82, 26);
            this.angerLabel.TabIndex = 12;
            this.angerLabel.Text = "Anger:";
            // 
            // sorrowLabel
            // 
            this.sorrowLabel.AutoSize = true;
            this.sorrowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorrowLabel.Location = new System.Drawing.Point(1584, 168);
            this.sorrowLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sorrowLabel.Name = "sorrowLabel";
            this.sorrowLabel.Size = new System.Drawing.Size(94, 26);
            this.sorrowLabel.TabIndex = 13;
            this.sorrowLabel.Text = "Sorrow:";
            // 
            // joyLabel
            // 
            this.joyLabel.AutoSize = true;
            this.joyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joyLabel.Location = new System.Drawing.Point(1584, 100);
            this.joyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.joyLabel.Name = "joyLabel";
            this.joyLabel.Size = new System.Drawing.Size(56, 26);
            this.joyLabel.TabIndex = 14;
            this.joyLabel.Text = "Joy:";
            // 
            // surpriseOutput
            // 
            this.surpriseOutput.Location = new System.Drawing.Point(1710, 286);
            this.surpriseOutput.Margin = new System.Windows.Forms.Padding(6);
            this.surpriseOutput.Name = "surpriseOutput";
            this.surpriseOutput.Size = new System.Drawing.Size(140, 31);
            this.surpriseOutput.TabIndex = 15;
            // 
            // confidenceOutput
            // 
            this.confidenceOutput.Location = new System.Drawing.Point(1746, 32);
            this.confidenceOutput.Margin = new System.Windows.Forms.Padding(6);
            this.confidenceOutput.Name = "confidenceOutput";
            this.confidenceOutput.Size = new System.Drawing.Size(106, 31);
            this.confidenceOutput.TabIndex = 16;
            // 
            // joyOutput
            // 
            this.joyOutput.Location = new System.Drawing.Point(1656, 100);
            this.joyOutput.Margin = new System.Windows.Forms.Padding(6);
            this.joyOutput.Name = "joyOutput";
            this.joyOutput.Size = new System.Drawing.Size(194, 31);
            this.joyOutput.TabIndex = 17;
            // 
            // sorrowOutput
            // 
            this.sorrowOutput.Location = new System.Drawing.Point(1696, 168);
            this.sorrowOutput.Margin = new System.Windows.Forms.Padding(6);
            this.sorrowOutput.Name = "sorrowOutput";
            this.sorrowOutput.Size = new System.Drawing.Size(154, 31);
            this.sorrowOutput.TabIndex = 18;
            // 
            // angerOutput
            // 
            this.angerOutput.Location = new System.Drawing.Point(1684, 228);
            this.angerOutput.Margin = new System.Windows.Forms.Padding(6);
            this.angerOutput.Name = "angerOutput";
            this.angerOutput.Size = new System.Drawing.Size(166, 31);
            this.angerOutput.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1880, 1064);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "moodi.io";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
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

