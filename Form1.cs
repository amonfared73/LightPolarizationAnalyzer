using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;

namespace Polarimeter
{
    public partial class Form1 : Form
    {

        public static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }

        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button_close, "Close");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_main.Controls.Add(Home.Instance);
            Home.Instance.Dock = DockStyle.Fill;
            Home.Instance.BringToFront();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            panel_selector.Height = button_home.Height;
            panel_selector.Top = button_home.Top;

            if (!panel_main.Controls.Contains(Home.Instance))
            {
                panel_main.Controls.Add(Home.Instance);
                Home.Instance.Dock = DockStyle.Fill;
                Home.Instance.BringToFront();
            }
            else
                Home.Instance.BringToFront();
        }

        private void button_signal_Click(object sender, EventArgs e)
        {
            panel_selector.Height = button_signal.Height;
            panel_selector.Top = button_signal.Top;

            if (!panel_main.Controls.Contains(Output_signal.Instance))
            {
                panel_main.Controls.Add(Output_signal.Instance);
                Output_signal.Instance.Dock = DockStyle.Fill;
                Output_signal.Instance.BringToFront();
            }
            else
                Output_signal.Instance.BringToFront();
        }

        private void button_polarization_ellipse_Click(object sender, EventArgs e)
        {
            panel_selector.Height = button_polarization_ellipse.Height;
            panel_selector.Top = button_polarization_ellipse.Top;

            if (!panel_main.Controls.Contains(Polarization_Ellipse.Instance))
            {
                panel_main.Controls.Add(Polarization_Ellipse.Instance);
                Polarization_Ellipse.Instance.Dock = DockStyle.Fill;
                Polarization_Ellipse.Instance.BringToFront();
            }
            else
                Polarization_Ellipse.Instance.BringToFront();
        }

        private void button_poincare_Click(object sender, EventArgs e)
        {
            panel_selector.Height = button_poincare.Height;
            panel_selector.Top = button_poincare.Top;

            if (!panel_main.Controls.Contains(Poincare_Sphere.Instance))
            {
                panel_main.Controls.Add(Poincare_Sphere.Instance);
                Poincare_Sphere.Instance.Dock = DockStyle.Fill;
                Poincare_Sphere.Instance.BringToFront();
            }
            else
                Poincare_Sphere.Instance.BringToFront();
        }

        private void button_analytical_Click(object sender, EventArgs e)
        {
            panel_selector.Height = button_analytical.Height;
            panel_selector.Top = button_analytical.Top;

            if (!panel_main.Controls.Contains(Analytical_Soloutions.Instance))
            {
                panel_main.Controls.Add(Analytical_Soloutions.Instance);
                Analytical_Soloutions.Instance.Dock = DockStyle.Fill;
                Analytical_Soloutions.Instance.BringToFront();
            }
            else
                Analytical_Soloutions.Instance.BringToFront();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            panel_selector.Height = button_about.Height;
            panel_selector.Top = button_about.Top;

            if (!panel_main.Controls.Contains(About.Instance))
            {
                panel_main.Controls.Add(About.Instance);
                About.Instance.Dock = DockStyle.Fill;
                About.Instance.BringToFront();
            }
            else
                About.Instance.BringToFront();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_stokes_Click(object sender, EventArgs e)
        {
            panel_selector.Height = button_stokes.Height;
            panel_selector.Top = button_stokes.Top;

            if (!panel_main.Controls.Contains(Stokes_parameters.Instance))
            {
                panel_main.Controls.Add(Stokes_parameters.Instance);
                Stokes_parameters.Instance.Dock = DockStyle.Fill;
                Stokes_parameters.Instance.BringToFront();
            }
            else
                Stokes_parameters.Instance.BringToFront();
        }

        private void label_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void label_title_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}