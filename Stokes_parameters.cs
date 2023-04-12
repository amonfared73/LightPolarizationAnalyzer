using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polarimeter
{
    public partial class Stokes_parameters : UserControl
    {
        public static Stokes_parameters _instance;
        public static Stokes_parameters Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Stokes_parameters();
                return _instance;
            }
        }
        public Label S_zero_label
        {
            get
            {
                return this.label_S_zero;
            }
        }
        public Label S_one_label
        {
            get
            {
                return this.label_S_one;
            }
        }
        public Label S_two_label
        {
            get
            {
                return this.label_S_two;
            }
        }
        public Label S_three_label
        {
            get
            {
                return this.label_S_three;
            }
        }
        public Stokes_parameters()
        {
            InitializeComponent();
        }
    }
}
