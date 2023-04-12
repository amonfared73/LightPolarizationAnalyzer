using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Polarimeter
{
    class random_coherency_matrix
    {
        readonly double xx;
        readonly double yy;
        readonly double xy_real;
        readonly double xy_imag;
        public random_coherency_matrix()
        {
            double mag = Functions.RandomNumberBetween(1, 10);

            double Gxx = Functions.RandomNumberBetween(0, 1);
            double Gyy = Functions.RandomNumberBetween(0, 1);

            Complex Gxy = new Complex(2, 0);

            while(Complex.Abs(Gxy) > (Gxx * Gyy))
            {
                Gxy = new Complex(Functions.RandomNumberBetween(-1, 1), Functions.RandomNumberBetween(-1, 1));
            }

            this.xx = Math.Round(mag * Gxx, 3);
            this.xy_real = Math.Round(mag * Gxy.Real, 3);
            this.xy_imag = Math.Round(mag * Gxy.Imaginary, 3);
            this.yy = Math.Round(mag * Gyy, 3);
        }

        public double getGxx()
        {
            return xx;
        }
        public double getGyy()
        {
            return yy;
        }
        public double getGxyreal()
        {
            return xy_real;
        }
        public double getGxyimag()
        {
            return xy_imag;
        }
    }
}
