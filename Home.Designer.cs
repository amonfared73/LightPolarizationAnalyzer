namespace Polarimeter
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label_coherency_title = new System.Windows.Forms.Label();
            this.pictureBox_coherency = new System.Windows.Forms.PictureBox();
            this.label_cohrency_info = new System.Windows.Forms.Label();
            this.panel_coherency_slide = new System.Windows.Forms.Panel();
            this.pictureBox_Gxx = new System.Windows.Forms.PictureBox();
            this.pictureBox_Gyy = new System.Windows.Forms.PictureBox();
            this.pictureBox_ReGxy = new System.Windows.Forms.PictureBox();
            this.pictureBox_ImGxy = new System.Windows.Forms.PictureBox();
            this.textBox_Gxx = new System.Windows.Forms.TextBox();
            this.textBox_Gyy = new System.Windows.Forms.TextBox();
            this.textBox_ReGxy = new System.Windows.Forms.TextBox();
            this.textBox_ImGxy = new System.Windows.Forms.TextBox();
            this.button_coherency_random = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coherency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gxx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gyy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ReGxy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImGxy)).BeginInit();
            this.SuspendLayout();
            // 
            // label_coherency_title
            // 
            this.label_coherency_title.AutoSize = true;
            this.label_coherency_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coherency_title.Location = new System.Drawing.Point(15, 26);
            this.label_coherency_title.Name = "label_coherency_title";
            this.label_coherency_title.Size = new System.Drawing.Size(175, 23);
            this.label_coherency_title.TabIndex = 0;
            this.label_coherency_title.Text = "Coherency Matrix";
            // 
            // pictureBox_coherency
            // 
            this.pictureBox_coherency.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_coherency.Image")));
            this.pictureBox_coherency.Location = new System.Drawing.Point(565, 67);
            this.pictureBox_coherency.Name = "pictureBox_coherency";
            this.pictureBox_coherency.Size = new System.Drawing.Size(225, 132);
            this.pictureBox_coherency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_coherency.TabIndex = 1;
            this.pictureBox_coherency.TabStop = false;
            // 
            // label_cohrency_info
            // 
            this.label_cohrency_info.AutoSize = true;
            this.label_cohrency_info.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cohrency_info.Location = new System.Drawing.Point(35, 67);
            this.label_cohrency_info.Name = "label_cohrency_info";
            this.label_cohrency_info.Size = new System.Drawing.Size(524, 119);
            this.label_cohrency_info.TabIndex = 2;
            this.label_cohrency_info.Text = resources.GetString("label_cohrency_info.Text");
            // 
            // panel_coherency_slide
            // 
            this.panel_coherency_slide.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_coherency_slide.Location = new System.Drawing.Point(19, 69);
            this.panel_coherency_slide.Name = "panel_coherency_slide";
            this.panel_coherency_slide.Size = new System.Drawing.Size(10, 116);
            this.panel_coherency_slide.TabIndex = 3;
            // 
            // pictureBox_Gxx
            // 
            this.pictureBox_Gxx.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Gxx.Image")));
            this.pictureBox_Gxx.Location = new System.Drawing.Point(8, 243);
            this.pictureBox_Gxx.Name = "pictureBox_Gxx";
            this.pictureBox_Gxx.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_Gxx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Gxx.TabIndex = 4;
            this.pictureBox_Gxx.TabStop = false;
            // 
            // pictureBox_Gyy
            // 
            this.pictureBox_Gyy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Gyy.Image")));
            this.pictureBox_Gyy.Location = new System.Drawing.Point(8, 324);
            this.pictureBox_Gyy.Name = "pictureBox_Gyy";
            this.pictureBox_Gyy.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_Gyy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Gyy.TabIndex = 4;
            this.pictureBox_Gyy.TabStop = false;
            // 
            // pictureBox_ReGxy
            // 
            this.pictureBox_ReGxy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ReGxy.Image")));
            this.pictureBox_ReGxy.Location = new System.Drawing.Point(317, 244);
            this.pictureBox_ReGxy.Name = "pictureBox_ReGxy";
            this.pictureBox_ReGxy.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_ReGxy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ReGxy.TabIndex = 4;
            this.pictureBox_ReGxy.TabStop = false;
            // 
            // pictureBox_ImGxy
            // 
            this.pictureBox_ImGxy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ImGxy.Image")));
            this.pictureBox_ImGxy.Location = new System.Drawing.Point(317, 325);
            this.pictureBox_ImGxy.Name = "pictureBox_ImGxy";
            this.pictureBox_ImGxy.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_ImGxy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ImGxy.TabIndex = 4;
            this.pictureBox_ImGxy.TabStop = false;
            // 
            // textBox_Gxx
            // 
            this.textBox_Gxx.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Gxx.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Gxx.Location = new System.Drawing.Point(99, 253);
            this.textBox_Gxx.Name = "textBox_Gxx";
            this.textBox_Gxx.Size = new System.Drawing.Size(116, 31);
            this.textBox_Gxx.TabIndex = 5;
            this.textBox_Gxx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Gxx_KeyPress);
            // 
            // textBox_Gyy
            // 
            this.textBox_Gyy.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Gyy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Gyy.Location = new System.Drawing.Point(99, 334);
            this.textBox_Gyy.Name = "textBox_Gyy";
            this.textBox_Gyy.Size = new System.Drawing.Size(116, 31);
            this.textBox_Gyy.TabIndex = 5;
            this.textBox_Gyy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Gyy_KeyPress);
            // 
            // textBox_ReGxy
            // 
            this.textBox_ReGxy.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_ReGxy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ReGxy.Location = new System.Drawing.Point(443, 254);
            this.textBox_ReGxy.Name = "textBox_ReGxy";
            this.textBox_ReGxy.Size = new System.Drawing.Size(116, 31);
            this.textBox_ReGxy.TabIndex = 5;
            this.textBox_ReGxy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ReGxy_KeyPress);
            // 
            // textBox_ImGxy
            // 
            this.textBox_ImGxy.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_ImGxy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ImGxy.Location = new System.Drawing.Point(443, 335);
            this.textBox_ImGxy.Name = "textBox_ImGxy";
            this.textBox_ImGxy.Size = new System.Drawing.Size(116, 31);
            this.textBox_ImGxy.TabIndex = 5;
            this.textBox_ImGxy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ImGxy_KeyPress);
            // 
            // button_coherency_random
            // 
            this.button_coherency_random.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_coherency_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_coherency_random.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_coherency_random.ForeColor = System.Drawing.SystemColors.Control;
            this.button_coherency_random.Location = new System.Drawing.Point(649, 286);
            this.button_coherency_random.Name = "button_coherency_random";
            this.button_coherency_random.Size = new System.Drawing.Size(141, 41);
            this.button_coherency_random.TabIndex = 6;
            this.button_coherency_random.Text = "Random Values";
            this.button_coherency_random.UseVisualStyleBackColor = false;
            this.button_coherency_random.Click += new System.EventHandler(this.button_coherency_random_Click);
            // 
            // button_run
            // 
            this.button_run.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_run.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_run.ForeColor = System.Drawing.SystemColors.Control;
            this.button_run.Location = new System.Drawing.Point(649, 382);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(141, 41);
            this.button_run.TabIndex = 6;
            this.button_run.Text = "Execute";
            this.button_run.UseVisualStyleBackColor = false;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.button_clear.Location = new System.Drawing.Point(649, 334);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(141, 41);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.button_coherency_random);
            this.Controls.Add(this.textBox_ImGxy);
            this.Controls.Add(this.textBox_ReGxy);
            this.Controls.Add(this.textBox_Gyy);
            this.Controls.Add(this.textBox_Gxx);
            this.Controls.Add(this.pictureBox_ImGxy);
            this.Controls.Add(this.pictureBox_ReGxy);
            this.Controls.Add(this.pictureBox_Gyy);
            this.Controls.Add(this.pictureBox_Gxx);
            this.Controls.Add(this.panel_coherency_slide);
            this.Controls.Add(this.label_cohrency_info);
            this.Controls.Add(this.pictureBox_coherency);
            this.Controls.Add(this.label_coherency_title);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(808, 440);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coherency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gxx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ReGxy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImGxy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_coherency_title;
        private System.Windows.Forms.PictureBox pictureBox_coherency;
        private System.Windows.Forms.Label label_cohrency_info;
        private System.Windows.Forms.Panel panel_coherency_slide;
        private System.Windows.Forms.PictureBox pictureBox_Gxx;
        private System.Windows.Forms.PictureBox pictureBox_Gyy;
        private System.Windows.Forms.PictureBox pictureBox_ReGxy;
        private System.Windows.Forms.PictureBox pictureBox_ImGxy;
        private System.Windows.Forms.TextBox textBox_Gxx;
        private System.Windows.Forms.TextBox textBox_Gyy;
        private System.Windows.Forms.TextBox textBox_ReGxy;
        private System.Windows.Forms.TextBox textBox_ImGxy;
        private System.Windows.Forms.Button button_coherency_random;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Button button_clear;
    }
}
