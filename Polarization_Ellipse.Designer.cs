namespace Polarimeter
{
    partial class Polarization_Ellipse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polarization_Ellipse));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label_polarization_elipse_title = new System.Windows.Forms.Label();
            this.panel_polarization_ellipse_slide = new System.Windows.Forms.Panel();
            this.label_polarization_ellipse_info = new System.Windows.Forms.Label();
            this.chart_ellipse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox_psi = new System.Windows.Forms.PictureBox();
            this.pictureBox_chi = new System.Windows.Forms.PictureBox();
            this.pictureBox_dop = new System.Windows.Forms.PictureBox();
            this.label_psi = new System.Windows.Forms.Label();
            this.label_chi = new System.Windows.Forms.Label();
            this.label_dop = new System.Windows.Forms.Label();
            this.progressBar_DOP = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ellipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_psi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dop)).BeginInit();
            this.SuspendLayout();
            // 
            // label_polarization_elipse_title
            // 
            this.label_polarization_elipse_title.AutoSize = true;
            this.label_polarization_elipse_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_polarization_elipse_title.Location = new System.Drawing.Point(15, 26);
            this.label_polarization_elipse_title.Name = "label_polarization_elipse_title";
            this.label_polarization_elipse_title.Size = new System.Drawing.Size(181, 23);
            this.label_polarization_elipse_title.TabIndex = 1;
            this.label_polarization_elipse_title.Text = "Polarization Ellipse";
            // 
            // panel_polarization_ellipse_slide
            // 
            this.panel_polarization_ellipse_slide.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_polarization_ellipse_slide.Location = new System.Drawing.Point(19, 69);
            this.panel_polarization_ellipse_slide.Name = "panel_polarization_ellipse_slide";
            this.panel_polarization_ellipse_slide.Size = new System.Drawing.Size(10, 62);
            this.panel_polarization_ellipse_slide.TabIndex = 5;
            // 
            // label_polarization_ellipse_info
            // 
            this.label_polarization_ellipse_info.AutoSize = true;
            this.label_polarization_ellipse_info.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_polarization_ellipse_info.Location = new System.Drawing.Point(35, 67);
            this.label_polarization_ellipse_info.Name = "label_polarization_ellipse_info";
            this.label_polarization_ellipse_info.Size = new System.Drawing.Size(337, 68);
            this.label_polarization_ellipse_info.TabIndex = 4;
            this.label_polarization_ellipse_info.Text = resources.GetString("label_polarization_ellipse_info.Text");
            // 
            // chart_ellipse
            // 
            this.chart_ellipse.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.chart_ellipse.ChartAreas.Add(chartArea3);
            this.chart_ellipse.Location = new System.Drawing.Point(394, 45);
            this.chart_ellipse.Name = "chart_ellipse";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "ellipse";
            this.chart_ellipse.Series.Add(series3);
            this.chart_ellipse.Size = new System.Drawing.Size(397, 380);
            this.chart_ellipse.TabIndex = 6;
            this.chart_ellipse.Text = "chart1";
            // 
            // pictureBox_psi
            // 
            this.pictureBox_psi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_psi.Image")));
            this.pictureBox_psi.Location = new System.Drawing.Point(38, 186);
            this.pictureBox_psi.Name = "pictureBox_psi";
            this.pictureBox_psi.Size = new System.Drawing.Size(83, 35);
            this.pictureBox_psi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_psi.TabIndex = 7;
            this.pictureBox_psi.TabStop = false;
            // 
            // pictureBox_chi
            // 
            this.pictureBox_chi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_chi.Image")));
            this.pictureBox_chi.Location = new System.Drawing.Point(38, 253);
            this.pictureBox_chi.Name = "pictureBox_chi";
            this.pictureBox_chi.Size = new System.Drawing.Size(83, 36);
            this.pictureBox_chi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_chi.TabIndex = 8;
            this.pictureBox_chi.TabStop = false;
            // 
            // pictureBox_dop
            // 
            this.pictureBox_dop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_dop.Image")));
            this.pictureBox_dop.Location = new System.Drawing.Point(38, 321);
            this.pictureBox_dop.Name = "pictureBox_dop";
            this.pictureBox_dop.Size = new System.Drawing.Size(83, 36);
            this.pictureBox_dop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_dop.TabIndex = 8;
            this.pictureBox_dop.TabStop = false;
            // 
            // label_psi
            // 
            this.label_psi.AutoSize = true;
            this.label_psi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_psi.Location = new System.Drawing.Point(132, 192);
            this.label_psi.Name = "label_psi";
            this.label_psi.Size = new System.Drawing.Size(64, 22);
            this.label_psi.TabIndex = 9;
            this.label_psi.Text = "= N/A";
            // 
            // label_chi
            // 
            this.label_chi.AutoSize = true;
            this.label_chi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chi.Location = new System.Drawing.Point(132, 260);
            this.label_chi.Name = "label_chi";
            this.label_chi.Size = new System.Drawing.Size(64, 22);
            this.label_chi.TabIndex = 9;
            this.label_chi.Text = "= N/A";
            // 
            // label_dop
            // 
            this.label_dop.AutoSize = true;
            this.label_dop.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dop.Location = new System.Drawing.Point(132, 329);
            this.label_dop.Name = "label_dop";
            this.label_dop.Size = new System.Drawing.Size(64, 22);
            this.label_dop.TabIndex = 9;
            this.label_dop.Text = "= N/A";
            // 
            // progressBar_DOP
            // 
            this.progressBar_DOP.Location = new System.Drawing.Point(244, 329);
            this.progressBar_DOP.Name = "progressBar_DOP";
            this.progressBar_DOP.Size = new System.Drawing.Size(144, 23);
            this.progressBar_DOP.TabIndex = 10;
            // 
            // Polarization_Ellipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar_DOP);
            this.Controls.Add(this.label_dop);
            this.Controls.Add(this.label_chi);
            this.Controls.Add(this.label_psi);
            this.Controls.Add(this.pictureBox_dop);
            this.Controls.Add(this.pictureBox_chi);
            this.Controls.Add(this.pictureBox_psi);
            this.Controls.Add(this.chart_ellipse);
            this.Controls.Add(this.panel_polarization_ellipse_slide);
            this.Controls.Add(this.label_polarization_ellipse_info);
            this.Controls.Add(this.label_polarization_elipse_title);
            this.Name = "Polarization_Ellipse";
            this.Size = new System.Drawing.Size(808, 440);
            ((System.ComponentModel.ISupportInitialize)(this.chart_ellipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_psi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_polarization_elipse_title;
        private System.Windows.Forms.Panel panel_polarization_ellipse_slide;
        private System.Windows.Forms.Label label_polarization_ellipse_info;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ellipse;
        private System.Windows.Forms.PictureBox pictureBox_psi;
        private System.Windows.Forms.PictureBox pictureBox_chi;
        private System.Windows.Forms.PictureBox pictureBox_dop;
        private System.Windows.Forms.Label label_psi;
        private System.Windows.Forms.Label label_chi;
        private System.Windows.Forms.Label label_dop;
        private System.Windows.Forms.ProgressBar progressBar_DOP;
    }
}
