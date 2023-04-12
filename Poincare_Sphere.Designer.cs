namespace Polarimeter
{
    partial class Poincare_Sphere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poincare_Sphere));
            this.panel_sphere_slide = new System.Windows.Forms.Panel();
            this.label_sphere_info = new System.Windows.Forms.Label();
            this.label_sphere_title = new System.Windows.Forms.Label();
            this.pictureBox_sphere = new System.Windows.Forms.PictureBox();
            this.label_stokescoordinate = new System.Windows.Forms.Label();
            this.glControl_poincare = new OpenTK.GLControl();
            this.button_run_3d = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sphere)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_sphere_slide
            // 
            this.panel_sphere_slide.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_sphere_slide.Location = new System.Drawing.Point(19, 69);
            this.panel_sphere_slide.Name = "panel_sphere_slide";
            this.panel_sphere_slide.Size = new System.Drawing.Size(10, 131);
            this.panel_sphere_slide.TabIndex = 9;
            // 
            // label_sphere_info
            // 
            this.label_sphere_info.AutoSize = true;
            this.label_sphere_info.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sphere_info.Location = new System.Drawing.Point(35, 67);
            this.label_sphere_info.Name = "label_sphere_info";
            this.label_sphere_info.Size = new System.Drawing.Size(327, 136);
            this.label_sphere_info.TabIndex = 8;
            this.label_sphere_info.Text = resources.GetString("label_sphere_info.Text");
            // 
            // label_sphere_title
            // 
            this.label_sphere_title.AutoSize = true;
            this.label_sphere_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sphere_title.Location = new System.Drawing.Point(15, 26);
            this.label_sphere_title.Name = "label_sphere_title";
            this.label_sphere_title.Size = new System.Drawing.Size(161, 23);
            this.label_sphere_title.TabIndex = 7;
            this.label_sphere_title.Text = "Poincare Sphere";
            // 
            // pictureBox_sphere
            // 
            this.pictureBox_sphere.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_sphere.Image")));
            this.pictureBox_sphere.Location = new System.Drawing.Point(23, 226);
            this.pictureBox_sphere.Name = "pictureBox_sphere";
            this.pictureBox_sphere.Size = new System.Drawing.Size(302, 148);
            this.pictureBox_sphere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sphere.TabIndex = 10;
            this.pictureBox_sphere.TabStop = false;
            // 
            // label_stokescoordinate
            // 
            this.label_stokescoordinate.AutoSize = true;
            this.label_stokescoordinate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stokescoordinate.Location = new System.Drawing.Point(189, 256);
            this.label_stokescoordinate.Name = "label_stokescoordinate";
            this.label_stokescoordinate.Size = new System.Drawing.Size(64, 22);
            this.label_stokescoordinate.TabIndex = 12;
            this.label_stokescoordinate.Text = "= N/A";
            // 
            // glControl_poincare
            // 
            this.glControl_poincare.BackColor = System.Drawing.SystemColors.Control;
            this.glControl_poincare.ForeColor = System.Drawing.SystemColors.Control;
            this.glControl_poincare.Location = new System.Drawing.Point(440, 41);
            this.glControl_poincare.Name = "glControl_poincare";
            this.glControl_poincare.Size = new System.Drawing.Size(320, 320);
            this.glControl_poincare.TabIndex = 13;
            this.glControl_poincare.VSync = false;
            // 
            // button_run_3d
            // 
            this.button_run_3d.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_run_3d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_run_3d.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_run_3d.ForeColor = System.Drawing.SystemColors.Control;
            this.button_run_3d.Location = new System.Drawing.Point(23, 373);
            this.button_run_3d.Name = "button_run_3d";
            this.button_run_3d.Size = new System.Drawing.Size(106, 31);
            this.button_run_3d.TabIndex = 14;
            this.button_run_3d.Text = "Run 3D";
            this.button_run_3d.UseVisualStyleBackColor = false;
            this.button_run_3d.Click += new System.EventHandler(this.button1_Click);
            // 
            // Poincare_Sphere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_run_3d);
            this.Controls.Add(this.glControl_poincare);
            this.Controls.Add(this.label_stokescoordinate);
            this.Controls.Add(this.pictureBox_sphere);
            this.Controls.Add(this.panel_sphere_slide);
            this.Controls.Add(this.label_sphere_info);
            this.Controls.Add(this.label_sphere_title);
            this.Name = "Poincare_Sphere";
            this.Size = new System.Drawing.Size(808, 404);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sphere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_sphere_slide;
        private System.Windows.Forms.Label label_sphere_info;
        private System.Windows.Forms.Label label_sphere_title;
        private System.Windows.Forms.PictureBox pictureBox_sphere;
        private System.Windows.Forms.Label label_stokescoordinate;
        private OpenTK.GLControl glControl_poincare;
        private System.Windows.Forms.Button button_run_3d;
    }
}
