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
    public partial class Analytical_Soloutions : UserControl
    {
        public static Analytical_Soloutions _instance;
        public static Analytical_Soloutions Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Analytical_Soloutions();
                return _instance;
            }
        }
        public Analytical_Soloutions()
        {
            InitializeComponent();
        }
    }
}
