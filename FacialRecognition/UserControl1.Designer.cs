namespace FacialRecognition
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.angerOutput = new System.Windows.Forms.TextBox();
            this.sorrowOutput = new System.Windows.Forms.TextBox();
            this.joyOutput = new System.Windows.Forms.TextBox();
            this.confidenceOutput = new System.Windows.Forms.TextBox();
            this.surpriseOutput = new System.Windows.Forms.TextBox();
            this.joyLabel = new System.Windows.Forms.Label();
            this.sorrowLabel = new System.Windows.Forms.Label();
            this.angerLabel = new System.Windows.Forms.Label();
            this.supriseLabel = new System.Windows.Forms.Label();
            this.confidenceLabel = new System.Windows.Forms.Label();
            this.moodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.moodChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(32, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1204, 123);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Mood Detected";
            // 
            // angerOutput
            // 
            this.angerOutput.Location = new System.Drawing.Point(1068, 391);
            this.angerOutput.Name = "angerOutput";
            this.angerOutput.Size = new System.Drawing.Size(85, 20);
            this.angerOutput.TabIndex = 29;
            // 
            // sorrowOutput
            // 
            this.sorrowOutput.Location = new System.Drawing.Point(1073, 361);
            this.sorrowOutput.Name = "sorrowOutput";
            this.sorrowOutput.Size = new System.Drawing.Size(79, 20);
            this.sorrowOutput.TabIndex = 28;
            // 
            // joyOutput
            // 
            this.joyOutput.Location = new System.Drawing.Point(1053, 327);
            this.joyOutput.Name = "joyOutput";
            this.joyOutput.Size = new System.Drawing.Size(99, 20);
            this.joyOutput.TabIndex = 27;
            // 
            // confidenceOutput
            // 
            this.confidenceOutput.Location = new System.Drawing.Point(1098, 293);
            this.confidenceOutput.Name = "confidenceOutput";
            this.confidenceOutput.Size = new System.Drawing.Size(55, 20);
            this.confidenceOutput.TabIndex = 26;
            // 
            // surpriseOutput
            // 
            this.surpriseOutput.Location = new System.Drawing.Point(1080, 420);
            this.surpriseOutput.Name = "surpriseOutput";
            this.surpriseOutput.Size = new System.Drawing.Size(72, 20);
            this.surpriseOutput.TabIndex = 25;
            // 
            // joyLabel
            // 
            this.joyLabel.AutoSize = true;
            this.joyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joyLabel.Location = new System.Drawing.Point(1017, 327);
            this.joyLabel.Name = "joyLabel";
            this.joyLabel.Size = new System.Drawing.Size(30, 13);
            this.joyLabel.TabIndex = 24;
            this.joyLabel.Text = "Joy:";
            // 
            // sorrowLabel
            // 
            this.sorrowLabel.AutoSize = true;
            this.sorrowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorrowLabel.Location = new System.Drawing.Point(1017, 361);
            this.sorrowLabel.Name = "sorrowLabel";
            this.sorrowLabel.Size = new System.Drawing.Size(50, 13);
            this.sorrowLabel.TabIndex = 23;
            this.sorrowLabel.Text = "Sorrow:";
            // 
            // angerLabel
            // 
            this.angerLabel.AutoSize = true;
            this.angerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angerLabel.Location = new System.Drawing.Point(1017, 391);
            this.angerLabel.Name = "angerLabel";
            this.angerLabel.Size = new System.Drawing.Size(44, 13);
            this.angerLabel.TabIndex = 22;
            this.angerLabel.Text = "Anger:";
            // 
            // supriseLabel
            // 
            this.supriseLabel.AutoSize = true;
            this.supriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supriseLabel.Location = new System.Drawing.Point(1017, 423);
            this.supriseLabel.Name = "supriseLabel";
            this.supriseLabel.Size = new System.Drawing.Size(57, 13);
            this.supriseLabel.TabIndex = 21;
            this.supriseLabel.Text = "Surprise:";
            // 
            // confidenceLabel
            // 
            this.confidenceLabel.AutoSize = true;
            this.confidenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confidenceLabel.Location = new System.Drawing.Point(1017, 296);
            this.confidenceLabel.Name = "confidenceLabel";
            this.confidenceLabel.Size = new System.Drawing.Size(75, 13);
            this.confidenceLabel.TabIndex = 20;
            this.confidenceLabel.Text = "Confidence:";
            // 
            // moodChart
            // 
            chartArea1.Name = "ChartArea1";
            this.moodChart.ChartAreas.Add(chartArea1);
            this.moodChart.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            legend1.Name = "Legend1";
            this.moodChart.Legends.Add(legend1);
            this.moodChart.Location = new System.Drawing.Point(954, 590);
            this.moodChart.Name = "moodChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Moods";
            this.moodChart.Series.Add(series1);
            this.moodChart.Size = new System.Drawing.Size(282, 216);
            this.moodChart.TabIndex = 30;
            this.moodChart.Text = "Mood Chart";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 618);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(638, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 618);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(339, 188);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 618);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.moodChart);
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
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1264, 887);
            ((System.ComponentModel.ISupportInitialize)(this.moodChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox angerOutput;
        private System.Windows.Forms.TextBox sorrowOutput;
        private System.Windows.Forms.TextBox joyOutput;
        private System.Windows.Forms.TextBox confidenceOutput;
        private System.Windows.Forms.TextBox surpriseOutput;
        private System.Windows.Forms.Label joyLabel;
        private System.Windows.Forms.Label sorrowLabel;
        private System.Windows.Forms.Label angerLabel;
        private System.Windows.Forms.Label supriseLabel;
        private System.Windows.Forms.Label confidenceLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart moodChart;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
