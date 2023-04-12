using System;
using System.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace Polarimeter
{
    class Functions
    {

        //Random Number Generator
        private static readonly Random random = new Random();
        public static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();
            return minValue + (next * (maxValue - minValue));
        }

        // SWAP TWO COMPLEX NUMBERS
        public static void swap(Complex a, Complex b)
        {
            Complex temp = a;
            b = temp;
            a = b;
        }

        // ARRAY GENERATOR
        public static double[] generate_array(double a, double b, double c)
        {
            double distance = c - a;
            double steps = distance / b;
            int N = (int)Math.Round(steps) + 1;
            double[] arr = new double[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = a + i * b;
            }
            return arr;
        }

        // GENERATE ARRAY OF ZEROS
        public static double[] zero_array(int L)
        {
            double[] arr = new double[L];
            for (int i = 0; i < L; i++)
            {
                arr[i] = 0;
            }
            return arr;
        }

        //MATRIX MULTIPLICATION
        public static Complex[,] Matrix_multiply(Complex[,] arr1, Complex[,] arr2)
        {
            Complex[,] Result = new Complex[arr1.GetLength(0), arr2.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Result[i, j] = 0;
                    for (int k = 0; k < arr1.GetLength(1); k++)
                    {
                        Result[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            return Result;
        }

        // MULTIPLY TWO ARRAYS OF THE SAME LENGTH
        public static double[] array_mult(double[] a, double[] b)
        {
            double[] z = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                z[i] = a[i] * b[i];
            }
            return z;
        }

        // RADIAN TO DEGREE
        public static double rad2deg(double rad)
        {
            double deg = rad * (180 / Math.PI);
            return Math.Round(deg, 2);
        }

        // DEGREE TO RADIAN
        public static double deg2rad(double deg)
        {
            double rad = deg * (Math.PI / 180);
            return Math.Round(rad, 2);
        }


        // NUMERICAL INTEGRATION
        public static double numerical_integration(double[] x, double[] y, double upper_limit)
        {
            double sum = 0;
            double dx = x[1] - x[0];
            double convergence = Math.Pow(10, -5);
            int N = x.Length;
            for(int i = 0; i < N - 1; i++)
            {
                if (Math.Abs(x[i] - upper_limit) < convergence)
                {
                    break;
                }
                sum += y[i + 1] * dx;
            }
            return sum;
        }

        // MULTIPLIES A CONSTANT NUMBER BY AN ARRAY
        public static double[] const_mult_arr(double constant, double[] arr)
        {
            double[] z = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                z[i] = constant * arr[i];
            }
            return z;
        }

        // EXPONENTIAL OF A COMPLEX NUMBER
        public static Complex complex_exp(double phase)
        {
            Complex num = new Complex(Math.Cos(phase), Math.Sin(phase));
            return num;
        } 

        // GENERATE SINE WAVE
        public static double[] generate_sin(int n, double frequency, double phase, double[] time)
        {
            int L = time.Length;
            double[] z = new double[L];
            for (int i = 0; i < L; i++)
            {
                z[i] = Math.Sin(n * 2 * Math.PI * frequency * time[i] + phase);
            }
            return z;
        }

        // GENERATE COSINE WAVE
        public static double[] generate_cos(int n, double frequency, double phase, double[] time)
        {
            int L = time.Length;
            double[] z = new double[L];
            for (int i = 0; i < L; i++)
            {
                z[i] = Math.Cos(n * 2 * Math.PI * frequency * time[i] + phase);
            }
            return z;
        }

        // POLARIZER WITH ANGLE ALPHA WITH RESPECT TO X AXIS
        public static Complex[,] polarizer(double alpha)
        {
            Complex[,] pol = new Complex[2, 2] { { Math.Pow(Math.Cos(alpha), 2), Math.Sin(alpha) * Math.Cos(alpha) }, { Math.Sin(alpha) * Math.Cos(alpha), Math.Pow(Math.Sin(alpha), 2) } };
            return pol;
        }

        // WAVE PLATE WITH PHASE RETARDATION ALPHA
        public static Complex[,] retarder(double alpha)
        {
            Complex[,] ret = new Complex[2, 2] { { 1, 0 }, { 0, Functions.complex_exp(-alpha) } };
            return ret;
        }

        // COORDINATE TRANSFORM MATRIX
        public static Complex[,] rotation(double alpha)
        {
            Complex[,] r = new Complex[2, 2] { { Math.Cos(alpha), Math.Sin(alpha) }, { -Math.Sin(alpha), Math.Cos(alpha) } };
            return r;
        }

        // COHERENCY MATRIX
        public static Complex[,] Coherency_matrix(double Gxx, double Gxy_real, double Gxy_imag, double Gyy)
        {
            Complex Gxy = new Complex(Gxy_real, Gxy_imag);
            Complex[,] G = new Complex[2, 2] { { Gxx, Gxy }, { Complex.Conjugate(Gxy), Gyy } };
            return G;
        }

        // CONJUGATE MATRIX
        public static Complex[,] conjugate(Complex[,] arr)
        {
            Complex[,] z = new Complex[2, 2];
            z[0, 0] = Complex.Conjugate(arr[0, 0]);
            z[1, 0] = Complex.Conjugate(arr[1, 0]);
            z[0, 1] = Complex.Conjugate(arr[0, 1]);
            z[1, 1] = Complex.Conjugate(arr[1, 1]);
            return z;
        }

        // TRANSPOSE MATRIX
        public static Complex[,] transpose(Complex[,] arr)
        {
            Complex[,] z = new Complex[2, 2];
            z[0, 0] = arr[0, 0];
            z[1, 0] = arr[0, 1];
            z[0, 1] = arr[1, 0];
            z[1, 1] = arr[1, 1];

            return z;
        }

        // COPY THE FIRST ARRAY INTO THE SECOND ONE
        public static Complex[] array_copy(double[] arr)
        {
            Complex[] result = new Complex[arr.Length];
            for(int i = 0; i < arr.Length; i++) {
                result[i] = arr[i];
            }
            return result;
        }

        // COPY THE FIRST ARRAY INTO THE SECOND ONE
        public static double[] array_copy_double(double[] arr)
        {
            double[] result = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i];
            }
            return result;
        }

        // CONHERNCY MATRIX CHECKER
        public static bool coherency_checker(double Gxx, double Gxy_real, double Gxy_imag, double Gyy)
        {
            double a = Math.Pow(Gxy_real, 2) + Math.Pow(Gxy_imag, 2);
            double b = Gxx * Gyy;
            if (a <= b)
            {
                return true;
            }
            else
                return false;
        }

        // PLOT SIGNAL
        public static void plot_signal(double[] x, double[] y)
        {
            Output_signal.Instance.Signal_Chart.Series["Signal"].Points.Clear();
            Output_signal.Instance.Signal_Chart.Series["Signal"].ChartType = SeriesChartType.Line;
            Output_signal.Instance.Signal_Chart.Series["Signal"].BorderWidth = 2;
            Output_signal.Instance.Signal_Chart.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 12.0f);
            Output_signal.Instance.Signal_Chart.ChartAreas["ChartArea1"].AxisX.Title = "Seconds";
            Output_signal.Instance.Signal_Chart.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 12.0f);
            Output_signal.Instance.Signal_Chart.ChartAreas["ChartArea1"].AxisY.Title = "Intensity [a.u]";
            for (int i = 0; i < x.Length; i++)
            {
                Output_signal.Instance.Signal_Chart.Series["Signal"].Points.AddXY(x[i], y[i]);
            }
            Output_signal.Instance.Signal_Chart.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            Output_signal.Instance.Signal_Chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        }

        public static void plot_fft(double[] y)
        {
            Output_signal.Instance.FFT_Chart.Series["FFT"].Points.Clear();
            Output_signal.Instance.FFT_Chart.Series["FFT"].Color = Color.Red;
            Output_signal.Instance.FFT_Chart.ChartAreas["ChartArea1"].AxisX.Title = "Frequency / Initial Frequency";
            Output_signal.Instance.FFT_Chart.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 12.0f);
            Output_signal.Instance.FFT_Chart.ChartAreas["ChartArea1"].AxisY.Title = "|FFT|";
            Output_signal.Instance.FFT_Chart.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 12.0f);
            Output_signal.Instance.FFT_Chart.Series["FFT"].BorderWidth = 2;
            Complex[] fft = array_copy(y);
            Fourier.Forward(fft, FourierOptions.NoScaling);
            fft[0] = fft[0] / 2;
            for (int i = 0; i < y.Length / 20; i++)
            {
                double mag = (2.0 / y.Length) * (Math.Abs(Math.Sqrt(Math.Pow(fft[i].Real, 2) + Math.Pow(fft[i].Imaginary, 2))));
                if (mag <= 0.05)
                {
                    mag = 0;
                }
                Output_signal.Instance.FFT_Chart.Series["FFT"].Points.AddXY(0.4 * i, mag);
            }
            Output_signal.Instance.FFT_Chart.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            Output_signal.Instance.FFT_Chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        }

        public static void plot_ellipse(double psi, double chi)
        {
            double X_mult = Math.Abs(Math.Cos(psi));
            double y_mult = Math.Abs(Math.Sin(psi));

            double[] curve = Functions.generate_array(0, 0.01, 1);

            double[] X_curve = Functions.generate_sin(1, 1, 2 * chi, curve);
            X_curve = Functions.const_mult_arr(X_mult, X_curve);

            double[] Y_curve = Functions.generate_sin(1, 1, 0, curve);
            Y_curve = Functions.const_mult_arr(y_mult, Y_curve);

            int L = curve.Length;
            Polarization_Ellipse.Instance.ellipse.Series["ellipse"].Points.Clear();
            Polarization_Ellipse.Instance.ellipse.Series["ellipse"].BorderWidth = 3;
            Polarization_Ellipse.Instance.ellipse.ChartAreas["ChartArea1"].AxisX.Minimum = -1;
            Polarization_Ellipse.Instance.ellipse.ChartAreas["ChartArea1"].AxisX.Maximum = 1;
            Polarization_Ellipse.Instance.ellipse.ChartAreas["ChartArea1"].AxisY.Minimum = -1;
            Polarization_Ellipse.Instance.ellipse.ChartAreas["ChartArea1"].AxisY.Maximum = 1;
            for (int i = 0; i < L; i++)
            {
                Polarization_Ellipse.Instance.ellipse.Series["ellipse"].Points.AddXY(X_curve[i], Y_curve[i]);
            }
        }

        public static void vector_resize(double constant, double[] arr1, double[] arr2, double[] arr3, double[] arr4)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = constant * arr1[i];
                arr2[i] = constant * arr2[i];
                arr3[i] = constant * arr3[i];
                arr4[i] = constant * arr4[i];
            }
        }

        public static void draw_line(double[] S)
        {
            GL.Color3(Color.Red);

            GL.LineWidth(3);
            GL.Begin(BeginMode.Lines);

            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(S[0], S[1], S[2]);

            GL.End();
        }

        public static void draw_sphere(bool Line, double radius)
        {
            if (Line == false)
            {
                GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
            }
            else
            {
                GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
            }

            double[] a, b, c, d;
            double delta_phi = 10;
            double delta_theta = 10;
            double c_factor = Math.PI / 180;

            GL.Color3(0.0, 0.0, 0.0);
            GL.Begin(BeginMode.Quads);

            for (double theta = 0; theta <= 180; theta += delta_theta)
            {
                for (double phi = 0; phi <= 360; phi += delta_phi)
                {
                    a = new double[3] { Math.Sin(theta * c_factor) * Math.Cos(phi * c_factor), Math.Sin(theta * c_factor) * Math.Sin(phi * c_factor), Math.Cos(theta * c_factor) };
                    b = new double[3] { Math.Sin(theta * c_factor + delta_theta * c_factor) * Math.Cos(phi * c_factor), Math.Sin(theta * c_factor + delta_theta * c_factor) * Math.Sin(phi * c_factor), Math.Cos(theta * c_factor + delta_theta * c_factor) };
                    c = new double[3] { Math.Sin(theta * c_factor + delta_theta * c_factor) * Math.Cos(phi * c_factor + delta_phi * c_factor), Math.Sin(theta * c_factor + delta_theta * c_factor) * Math.Sin(phi * c_factor + delta_phi * c_factor), Math.Cos(theta * c_factor + delta_theta * c_factor) };
                    d = new double[3] { Math.Sin(theta * c_factor) * Math.Cos(phi * c_factor + delta_phi * c_factor), Math.Sin(theta * c_factor) * Math.Sin(phi * c_factor + delta_phi * c_factor), Math.Cos(theta * c_factor) };

                    vector_resize(radius, a, b, c, d);

                    GL.Vertex3(a);
                    GL.Vertex3(b);
                    GL.Vertex3(c);
                    GL.Vertex3(d);
                }
            }

            GL.End();
        }

        public static void drawX()
        {
            GL.Begin(BeginMode.Lines);

            double[] a = new double[3] { 1.1, 0, 0 };
            double[] b = new double[3] { -1.1, 0, 0 };

            GL.Vertex3(a);
            GL.Vertex3(b);

            GL.End();
        }

        public static void drawY()
        {
            GL.Begin(BeginMode.Lines);

            double[] a = new double[3] { 0, 1.1, 0 };
            double[] b = new double[3] { 0, -1.1, 0 };

            GL.Vertex3(a);
            GL.Vertex3(b);

            GL.End();
        }

        public static void drawZ()
        {
            GL.Begin(BeginMode.Lines);

            double[] a = new double[3] { 0, 0, 1 };
            double[] b = new double[3] { 0, 0, -1 };

            GL.Vertex3(a);
            GL.Vertex3(b);

            GL.End();
        }
    }
}
