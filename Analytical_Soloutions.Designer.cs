namespace Polarimeter
{
    partial class Analytical_Soloutions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytical_Soloutions));
            this.panel_analytical_soloutions_slide = new System.Windows.Forms.Panel();
            this.label_polarization_ellipse_info = new System.Windows.Forms.Label();
            this.label_analytical_solutions_title = new System.Windows.Forms.Label();
            this.pictureBox_optical_setup = new System.Windows.Forms.PictureBox();
            this.pictureBox_intensity = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_optical_setup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_intensity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_analytical_soloutions_slide
            // 
            this.panel_analytical_soloutions_slide.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_analytical_soloutions_slide.Location = new System.Drawing.Point(19, 69);
            this.panel_analytical_soloutions_slide.Name = "panel_analytical_soloutions_slide";
            this.panel_analytical_soloutions_slide.Size = new System.Drawing.Size(10, 201);
            this.panel_analytical_soloutions_slide.TabIndex = 8;
            // 
            // label_polarization_ellipse_info
            // 
            this.label_polarization_ellipse_info.AutoSize = true;
            this.label_polarization_ellipse_info.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_polarization_ellipse_info.Location = new System.Drawing.Point(35, 67);
            this.label_polarization_ellipse_info.Name = "label_polarization_ellipse_info";
            this.label_polarization_ellipse_info.Size = new System.Drawing.Size(395, 204);
            this.label_polarization_ellipse_info.TabIndex = 7;
            this.label_polarization_ellipse_info.Text = resources.GetString("label_polarization_ellipse_info.Text");
            // 
            // label_analytical_solutions_title
            // 
            this.label_analytical_solutions_title.AutoSize = true;
            this.label_analytical_solutions_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_analytical_solutions_title.Location = new System.Drawing.Point(15, 26);
            this.label_analytical_solutions_title.Name = "label_analytical_solutions_title";
            this.label_analytical_solutions_title.Size = new System.Drawing.Size(202, 23);
            this.label_analytical_solutions_title.TabIndex = 6;
            this.label_analytical_solutions_title.Text = "Analytical Soloutions";
            // 
            // pictureBox_optical_setup
            // 
            this.pictureBox_optical_setup.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_optical_setup.Image")));
            this.pictureBox_optical_setup.Location = new System.Drawing.Point(430, 69);
            this.pictureBox_optical_setup.Name = "pictureBox_optical_setup";
            this.pictureBox_optical_setup.Size = new System.Drawing.Size(369, 220);
            this.pictureBox_optical_setup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_optical_setup.TabIndex = 9;
            this.pictureBox_optical_setup.TabStop = false;
            // 
            // pictureBox_intensity
            // 
            this.pictureBox_intensity.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_intensity.Image")));
            this.pictureBox_intensity.Location = new System.Drawing.Point(19, 333);
            this.pictureBox_intensity.Name = "pictureBox_intensity";
            this.pictureBox_intensity.Size = new System.Drawing.Size(770, 54);
            this.pictureBox_intensity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_intensity.TabIndex = 10;
            this.pictureBox_intensity.TabStop = false;
            // 
            // Analytical_Soloutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_intensity);
            this.Controls.Add(this.pictureBox_optical_setup);
            this.Controls.Add(this.panel_analytical_soloutions_slide);
            this.Controls.Add(this.label_polarization_ellipse_info);
            this.Controls.Add(this.label_analytical_solutions_title);
            this.Name = "Analytical_Soloutions";
            this.Size = new System.Drawing.Size(808, 440);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_optical_setup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_intensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_analytical_soloutions_slide;
        private System.Windows.Forms.Label label_polarization_ellipse_info;
        private System.Windows.Forms.Label label_analytical_solutions_title;
        private System.Windows.Forms.PictureBox pictureBox_optical_setup;
        private System.Windows.Forms.PictureBox pictureBox_intensity;
    }
}
