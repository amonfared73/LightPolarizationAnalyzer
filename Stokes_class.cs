using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polarimeter
{
    class Stokes_class
    {
        private double S0, S1, S2, S3;
        private double[] stokes = new double[3];
        private double psi, chi;
        private double DOP;

        public Stokes_class(double nu, double[] x, double[] y)
        {
            double period = 1 / nu;

            double[] a4 = Functions.generate_cos(4, nu, 0, x);
            a4 = Functions.array_mult(y, a4);

            double[] b4 = Functions.generate_sin(4, nu, 0, x);
            b4 = Functions.array_mult(y, b4);

            double[] b2 = Functions.generate_sin(2, nu, 0, x);
            b2 = Functions.array_mult(y, b2);

            double C1 = (1 / period) * Functions.numerical_integration(x, y, period);
            double C2 = (2 / period) * Functions.numerical_integration(x, a4, period);
            double C3 = (2 / period) * Functions.numerical_integration(x, b4, period);
            double C4 = (2 / period) * Functions.numerical_integration(x, b2, period);

            this.S0 = Math.Round(2 * (C1 - C2), 3);
            this.S1 = Math.Round(4 * C2, 3);
            this.S2 = Math.Round(-4 * C3, 3);
            this.S3 = Math.Round(2 * C4, 3);

            this.stokes[0] = Math.Round(this.S1 / this.S0, 3);
            this.stokes[1] = Math.Round(this.S2 / this.S0, 3);
            this.stokes[2] = Math.Round(this.S3 / this.S0, 3);

            this.DOP = (1 / this.S0) * Math.Sqrt(Math.Pow(this.S1, 2) + Math.Pow(this.S2, 2) + Math.Pow(this.S3, 2));

            Elipsometer stokes_elips = new Elipsometer(this.stokes);
            this.psi = stokes_elips.get_psi();
            this.chi = stokes_elips.get_chi();

        }

        public double get_S0()
        {
            return this.S0;
        }

        public double get_S1()
        {
            return this.S1;
        }

        public double get_S2()
        {
            return this.S2;
        }

        public double get_S3()
        {
            return this.S3;
        }

        public double[] get_stokes()
        {
            return this.stokes;
        }

        public double get_psi_angle(bool deg)
        {
            if (deg == true)
            {
                return Functions.rad2deg(this.psi);
            }
            else
                return Math.Round(this.chi, 2);
        }

        public double get_chi_angle(bool deg)
        {
            if (deg == true)
            {
                return Functions.rad2deg(this.chi);
            }
            else
                return Math.Round(this.chi, 2);
        }

        public double get_DOP()
        {
            return Math.Round(100 * this.DOP, 2);
        }
    }
}
