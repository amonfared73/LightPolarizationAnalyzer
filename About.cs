using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Polarimeter
{
    public partial class About : UserControl
    {
        public static About _instance;
        public static About Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new About();
                return _instance;
            }
        }
        public About()
        {
            InitializeComponent();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();

            ToolTip1.SetToolTip(this.button_dot_net, "A numerical foundation of the Math.NET project, aiming to \nprovide methods and algorithms for numerical computations \nin science, engineering and every day use");

            ToolTip1.SetToolTip(this.button_excel, "A spreadsheet library for .NET framework and .NET core");

            ToolTip1.SetToolTip(this.button_opengl, "Modern OpenGL bindings for C#");
        }

        private void button_twitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/amonfared73");
        }

        private void button_instagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/amonfared73");
        }

        private void button_telegram_Click(object sender, EventArgs e)
        {
            Process.Start("https://telegram.me/amonfared73");
        }

        private void button_twitter_MouseHover(object sender, EventArgs e)
        {
            label_twitter.ForeColor = Color.Black;
        }

        private void button_instagram_MouseHover(object sender, EventArgs e)
        {
            label_instagram.ForeColor = Color.Black;
        }

        private void button_telegram_MouseHover(object sender, EventArgs e)
        {
            label1_telegram.ForeColor = Color.Black;
        }

        private void button_twitter_MouseLeave(object sender, EventArgs e)
        {
            label_twitter.ForeColor = Color.FromArgb(240, 240, 240);
        }

        private void button_instagram_MouseLeave(object sender, EventArgs e)
        {
            label_instagram.ForeColor = Color.FromArgb(240, 240, 240);
        }

        private void button_telegram_MouseLeave(object sender, EventArgs e)
        {
            label1_telegram.ForeColor = Color.FromArgb(240, 240, 240);
        }

        private void button_dot_net_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nuget.org/packages/MathNet.Numerics/");
        }

        private void button_opengl_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nuget.org/packages/OpenGL.Net/");
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nuget.org/packages/EPPlus/");
        }
    }
}
