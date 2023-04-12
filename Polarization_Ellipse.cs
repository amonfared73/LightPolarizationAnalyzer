using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Polarimeter
{
    public partial class Polarization_Ellipse : UserControl
    {
        public static Polarization_Ellipse _instance;
        public static Polarization_Ellipse Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Polarization_Ellipse();
                return _instance;
            }
        }

        public Label psi_label
        {
            get
            {
                return this.label_psi;
            }
        }

        public Label chi_label
        {
            get
            {
                return this.label_chi;
            }
        }

        public Label dop_label
        {
            get
            {
                return this.label_dop;
            }
        }

        public Chart ellipse
        {
            get
            {
                return this.chart_ellipse;
            }
        }

        public ProgressBar DOP_Progress
        {
            get
            {
                return this.progressBar_DOP;
            }
        }

        public Polarization_Ellipse()
        {
            InitializeComponent();
        }
    }
}
