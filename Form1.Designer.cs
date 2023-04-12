namespace Polarimeter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.left_panel = new System.Windows.Forms.Panel();
            this.panel_selector = new System.Windows.Forms.Panel();
            this.button_about = new System.Windows.Forms.Button();
            this.button_analytical = new System.Windows.Forms.Button();
            this.button_poincare = new System.Windows.Forms.Button();
            this.button_polarization_ellipse = new System.Windows.Forms.Button();
            this.button_signal = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.button_stokes = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.title_panel = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.left_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.left_panel.Controls.Add(this.panel_selector);
            this.left_panel.Controls.Add(this.button_about);
            this.left_panel.Controls.Add(this.button_analytical);
            this.left_panel.Controls.Add(this.button_poincare);
            this.left_panel.Controls.Add(this.button_polarization_ellipse);
            this.left_panel.Controls.Add(this.button_signal);
            this.left_panel.Controls.Add(this.button_home);
            this.left_panel.Controls.Add(this.button_stokes);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(235, 690);
            this.left_panel.TabIndex = 1;
            // 
            // panel_selector
            // 
            this.panel_selector.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_selector.Location = new System.Drawing.Point(0, 135);
            this.panel_selector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_selector.Name = "panel_selector";
            this.panel_selector.Size = new System.Drawing.Size(13, 66);
            this.panel_selector.TabIndex = 1;
            // 
            // button_about
            // 
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_about.ForeColor = System.Drawing.Color.White;
            this.button_about.Location = new System.Drawing.Point(0, 549);
            this.button_about.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(235, 66);
            this.button_about.TabIndex = 7;
            this.button_about.Text = "    About";
            this.button_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_analytical
            // 
            this.button_analytical.FlatAppearance.BorderSize = 0;
            this.button_analytical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_analytical.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_analytical.ForeColor = System.Drawing.Color.White;
            this.button_analytical.Location = new System.Drawing.Point(0, 480);
            this.button_analytical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_analytical.Name = "button_analytical";
            this.button_analytical.Size = new System.Drawing.Size(235, 66);
            this.button_analytical.TabIndex = 6;
            this.button_analytical.Text = "    Analytical Soloution";
            this.button_analytical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_analytical.UseVisualStyleBackColor = true;
            this.button_analytical.Click += new System.EventHandler(this.button_analytical_Click);
            // 
            // button_poincare
            // 
            this.button_poincare.FlatAppearance.BorderSize = 0;
            this.button_poincare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_poincare.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_poincare.ForeColor = System.Drawing.Color.White;
            this.button_poincare.Location = new System.Drawing.Point(0, 411);
            this.button_poincare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_poincare.Name = "button_poincare";
            this.button_poincare.Size = new System.Drawing.Size(235, 66);
            this.button_poincare.TabIndex = 5;
            this.button_poincare.Text = "    Poincare Sphere";
            this.button_poincare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_poincare.UseVisualStyleBackColor = true;
            this.button_poincare.Click += new System.EventHandler(this.button_poincare_Click);
            // 
            // button_polarization_ellipse
            // 
            this.button_polarization_ellipse.FlatAppearance.BorderSize = 0;
            this.button_polarization_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_polarization_ellipse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_polarization_ellipse.ForeColor = System.Drawing.Color.White;
            this.button_polarization_ellipse.Location = new System.Drawing.Point(0, 342);
            this.button_polarization_ellipse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_polarization_ellipse.Name = "button_polarization_ellipse";
            this.button_polarization_ellipse.Size = new System.Drawing.Size(235, 66);
            this.button_polarization_ellipse.TabIndex = 4;
            this.button_polarization_ellipse.Text = "    Polarization Ellipse";
            this.button_polarization_ellipse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_polarization_ellipse.UseVisualStyleBackColor = true;
            this.button_polarization_ellipse.Click += new System.EventHandler(this.button_polarization_ellipse_Click);
            // 
            // button_signal
            // 
            this.button_signal.FlatAppearance.BorderSize = 0;
            this.button_signal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signal.ForeColor = System.Drawing.Color.White;
            this.button_signal.Location = new System.Drawing.Point(0, 204);
            this.button_signal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_signal.Name = "button_signal";
            this.button_signal.Size = new System.Drawing.Size(235, 66);
            this.button_signal.TabIndex = 2;
            this.button_signal.Text = "    Output Signal";
            this.button_signal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_signal.UseVisualStyleBackColor = true;
            this.button_signal.Click += new System.EventHandler(this.button_signal_Click);
            // 
            // button_home
            // 
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home.Location = new System.Drawing.Point(0, 135);
            this.button_home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(235, 66);
            this.button_home.TabIndex = 4;
            this.button_home.Text = "    Home";
            this.button_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_stokes
            // 
            this.button_stokes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_stokes.FlatAppearance.BorderSize = 0;
            this.button_stokes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stokes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stokes.ForeColor = System.Drawing.Color.White;
            this.button_stokes.Location = new System.Drawing.Point(0, 273);
            this.button_stokes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_stokes.Name = "button_stokes";
            this.button_stokes.Size = new System.Drawing.Size(235, 66);
            this.button_stokes.TabIndex = 3;
            this.button_stokes.Text = "    Stokes Parameters";
            this.button_stokes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_stokes.UseVisualStyleBackColor = false;
            this.button_stokes.Click += new System.EventHandler(this.button_stokes_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(235, 0);
            this.top_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1077, 12);
            this.top_panel.TabIndex = 0;
            // 
            // title_panel
            // 
            this.title_panel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.title_panel.Location = new System.Drawing.Point(251, 34);
            this.title_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(52, 80);
            this.title_panel.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(307, 28);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(539, 52);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Light Polarization Analyzer";
            this.label_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_title_MouseDown);
            this.label_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_title_MouseMove);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_info.Location = new System.Drawing.Point(316, 90);
            this.label_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(611, 25);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "Numerical analysis of a rotating retarder wave plate based polarimeter\r\n";
            // 
            // button_close
            // 
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Image = ((System.Drawing.Image)(resources.GetObject("button_close.Image")));
            this.button_close.Location = new System.Drawing.Point(1259, 18);
            this.button_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(47, 43);
            this.button_close.TabIndex = 5;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel_main
            // 
            this.panel_main.Location = new System.Drawing.Point(235, 150);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1077, 542);
            this.panel_main.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.title_panel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.left_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light Polarization Analayzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.left_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_analytical;
        private System.Windows.Forms.Button button_poincare;
        private System.Windows.Forms.Button button_polarization_ellipse;
        private System.Windows.Forms.Button button_signal;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Panel panel_selector;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_stokes;
        private System.Windows.Forms.Panel panel_main;
    }
}

