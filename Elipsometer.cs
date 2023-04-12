using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polarimeter
{
    class Elipsometer
    {
        
        double psi;
        double chi;


        public Elipsometer(double[] stokes)
        {
            double theta;
            double phi;

            if (stokes[0] == 0 && stokes[1] == 0 && stokes[2] == 0)
            {
                theta = Math.PI / 2;
                phi = 0;
            }
            else if (stokes[2] == 0 && stokes[0] == 0)
            {
                theta = Math.PI / 2;
                if (stokes[1] >= 0)
                {
                    phi = Math.PI / 2;
                }
                else
                {
                    phi = 3 * Math.PI / 2;
                }
            }
            else if (stokes[2] == 0)
            {
                theta = Math.PI / 2;
                phi = Math.Atan(stokes[1] / stokes[0]);
            }
            else if (stokes[0] == 0)
            {
                theta = Math.Atan(Math.Sqrt(Math.Pow(stokes[0], 2) + Math.Pow(stokes[1], 2)) / stokes[2]);
                if (stokes[1] >= 0)
                {
                    phi = Math.PI / 2;
                }
                else
                {
                    phi = 3 * Math.PI / 2;
                }
            }
            else
            {
                theta = Math.Atan(Math.Sqrt(Math.Pow(stokes[0], 2) + Math.Pow(stokes[1], 2)) / stokes[2]);
                phi = Math.Atan(stokes[1] / stokes[0]);
            }

            this.psi = 0.5 * phi;
            this.chi = 0.5 * (Math.PI / 2 - theta);
        }

        public double get_psi()
        {
            return this.psi;
        }
        public double get_chi()
        {
            return this.chi;
        }
    }
}
