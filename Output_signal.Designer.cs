namespace Polarimeter
{
    partial class Output_signal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Output_signal));
            this.label_signal_title = new System.Windows.Forms.Label();
            this.chart_signal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_fft = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_signal_slide = new System.Windows.Forms.Panel();
            this.label_signal_info = new System.Windows.Forms.Label();
            this.pictureBox_signal = new System.Windows.Forms.PictureBox();
            this.button_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_signal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_fft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_signal)).BeginInit();
            this.SuspendLayout();
            // 
            // label_signal_title
            // 
            this.label_signal_title.AutoSize = true;
            this.label_signal_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signal_title.Location = new System.Drawing.Point(15, 26);
            this.label_signal_title.Name = "label_signal_title";
            this.label_signal_title.Size = new System.Drawing.Size(135, 23);
            this.label_signal_title.TabIndex = 1;
            this.label_signal_title.Text = "Output Signal";
            // 
            // chart_signal
            // 
            this.chart_signal.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart_signal.ChartAreas.Add(chartArea1);
            this.chart_signal.Location = new System.Drawing.Point(233, 3);
            this.chart_signal.Name = "chart_signal";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Signal";
            this.chart_signal.Series.Add(series1);
            this.chart_signal.Size = new System.Drawing.Size(555, 207);
            this.chart_signal.TabIndex = 2;
            this.chart_signal.Text = "chart1";
            // 
            // chart_fft
            // 
            this.chart_fft.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chart_fft.ChartAreas.Add(chartArea2);
            this.chart_fft.Location = new System.Drawing.Point(233, 226);
            this.chart_fft.Name = "chart_fft";
            this.chart_fft.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Name = "FFT";
            this.chart_fft.Series.Add(series2);
            this.chart_fft.Size = new System.Drawing.Size(555, 211);
            this.chart_fft.TabIndex = 2;
            this.chart_fft.Text = "chart1";
            // 
            // panel_signal_slide
            // 
            this.panel_signal_slide.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_signal_slide.Location = new System.Drawing.Point(19, 69);
            this.panel_signal_slide.Name = "panel_signal_slide";
            this.panel_signal_slide.Size = new System.Drawing.Size(10, 73);
            this.panel_signal_slide.TabIndex = 4;
            // 
            // label_signal_info
            // 
            this.label_signal_info.AutoSize = true;
            this.label_signal_info.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signal_info.Location = new System.Drawing.Point(35, 72);
            this.label_signal_info.Name = "label_signal_info";
            this.label_signal_info.Size = new System.Drawing.Size(192, 68);
            this.label_signal_info.TabIndex = 5;
            this.label_signal_info.Text = "Light intensity genrated\r\nusing Transfer matrix method\r\n(Blue) and the Fast Fouri" +
    "er\r\nTransform (Red) spectrum";
            // 
            // pictureBox_signal
            // 
            this.pictureBox_signal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_signal.Image")));
            this.pictureBox_signal.Location = new System.Drawing.Point(19, 194);
            this.pictureBox_signal.Name = "pictureBox_signal";
            this.pictureBox_signal.Size = new System.Drawing.Size(208, 117);
            this.pictureBox_signal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_signal.TabIndex = 6;
            this.pictureBox_signal.TabStop = false;
            // 
            // button_excel
            // 
            this.button_excel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_excel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excel.ForeColor = System.Drawing.SystemColors.Control;
            this.button_excel.Location = new System.Drawing.Point(38, 355);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(141, 41);
            this.button_excel.TabIndex = 7;
            this.button_excel.Text = "Export to Excel";
            this.button_excel.UseVisualStyleBackColor = false;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // Output_signal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.pictureBox_signal);
            this.Controls.Add(this.label_signal_info);
            this.Controls.Add(this.panel_signal_slide);
            this.Controls.Add(this.chart_fft);
            this.Controls.Add(this.chart_signal);
            this.Controls.Add(this.label_signal_title);
            this.Name = "Output_signal";
            this.Size = new System.Drawing.Size(808, 440);
            ((System.ComponentModel.ISupportInitialize)(this.chart_signal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_fft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_signal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_signal_title;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_signal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_fft;
        private System.Windows.Forms.Panel panel_signal_slide;
        private System.Windows.Forms.Label label_signal_info;
        private System.Windows.Forms.PictureBox pictureBox_signal;
        private System.Windows.Forms.Button button_excel;
    }
}
