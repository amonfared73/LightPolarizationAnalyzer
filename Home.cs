using System;
using System.Windows.Forms;
using System.Numerics;

namespace Polarimeter
{
    public partial class Home : UserControl
    {
        public static Home _instance;
        public static Home Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Home();
                return _instance;
            }
        }
        public Home()
        {
            InitializeComponent();
        }

        // RANDOM COHERENCY MATRIX GENERATOR
        private void button_coherency_random_Click(object sender, EventArgs e)
        {
            random_coherency_matrix coherency_matrix = new random_coherency_matrix();

            textBox_Gxx.Clear();
            textBox_Gxx.Text = coherency_matrix.getGxx().ToString();

            textBox_Gyy.Clear();
            textBox_Gyy.Text = coherency_matrix.getGyy().ToString();

            textBox_ReGxy.Clear();
            textBox_ReGxy.Text = coherency_matrix.getGxyreal().ToString();

            textBox_ImGxy.Clear();
            textBox_ImGxy.Text = coherency_matrix.getGxyimag().ToString();
        }

        // CLEAR BUTTON
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Gxx.Clear();
            textBox_Gyy.Clear();
            textBox_ReGxy.Clear();
            textBox_ImGxy.Clear();
        }

        // EXECUTION PART
        private void button_run_Click(object sender, EventArgs e)
        {
            if (textBox_Gxx.Text == "" || textBox_Gyy.Text == "" || textBox_ImGxy.Text == "" || textBox_ReGxy.Text == "")
            {
                MessageBox.Show("Null values not acceptable!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Functions.coherency_checker(double.Parse(textBox_Gxx.Text), double.Parse(textBox_ReGxy.Text), double.Parse(textBox_ImGxy.Text), double.Parse(textBox_Gyy.Text)) == false)
            {
                MessageBox.Show("Consider the unequality |Gxx|.|Gyy| >= |Gxy|^2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                // COHERENCY MATRIX
                double Gxx = double.Parse(textBox_Gxx.Text);
                double Gxy_real = double.Parse(textBox_ReGxy.Text);
                double Gxy_imag = double.Parse(textBox_ImGxy.Text);
                double Gyy = double.Parse(textBox_Gyy.Text);
                Complex[,] G = Functions.Coherency_matrix(Gxx, Gxy_real, Gxy_imag, Gyy);

                // GLOBAL VARIABLES
                double pi = Math.PI;                                            // Pi = 3.1415...
                double dt = 0.01;                                               // TIME STEP
                double[] time = Functions.generate_array(0, dt, 5);             // TIME AARRAY
                int L = time.Length;                                            // TIME ARRAY LENGTH
                double nu = 0.5;                                                // ROTATION FREQUENCY [Hz]
                double omega = 2 * pi * nu;                                     // ANGULAR FREQUENCY
                double[] theta = Functions.const_mult_arr(omega, time);         // ANGLE ARRAY
                double phi = Functions.deg2rad(90);                             // WAVE PLATE RETARDATION PHASE
                double beta = Functions.deg2rad(0);                             // POLARIZER ANGLE WITH RESPECT TO X AXIS
                double[] intensity = Functions.zero_array(L);                   // OUTPUT INTENSITY ARRAY

                // OPTICAL DEVICES
                Complex[,] polarizer = Functions.polarizer(beta);               // POLARIZER WITH BETA = 0
                Complex[,] retarder = Functions.retarder(phi);                  // QUARTER WAVE RETARDER

                // CALCULATION LOOP
                for (int i = 0; i < L; i++)
                {
                    double angle = theta[i];                                    // RETARDER ANGLE AT EACH TIME STEP
                    Complex[,] r_plus = Functions.rotation(angle);              // R PLUS MATRIX
                    Complex[,] r_minus = Functions.rotation(-angle);            // R MINUS MATRIX
                    Complex[,] transfer_matrix = Functions.Matrix_multiply(polarizer, Functions.Matrix_multiply(r_plus, Functions.Matrix_multiply(retarder, r_minus)));     // TRANSFER MATRIX
                    Complex[,] t_star = Functions.conjugate(transfer_matrix);   // CONJUGATED TRANSFER MATRIX
                    Complex[,] t_dagger = Functions.transpose(transfer_matrix); // TRANSPOSED TRANSFER MATRIX
                    Complex[,] G_new = Functions.Matrix_multiply(t_star, Functions.Matrix_multiply(G, t_dagger));       // NEW COHERENCY MATRIX
                    intensity[i] = G_new[0, 0].Real + G_new[1, 1].Real;         // INTENSITY
                }

                Functions.plot_signal(time, intensity);
                Functions.plot_fft(intensity);

                Stokes_class stokes_params = new Stokes_class(nu, time, intensity);
                Stokes_parameters.Instance.S_zero_label.Text = "  =  " + stokes_params.get_S0().ToString() + "  [a.u]";
                Stokes_parameters.Instance.S_one_label.Text = "  =  " + stokes_params.get_S1().ToString() + "  [a.u]";
                Stokes_parameters.Instance.S_two_label.Text = "  =  " + stokes_params.get_S2().ToString() + "  [a.u]";
                Stokes_parameters.Instance.S_three_label.Text = "  =  " + stokes_params.get_S3().ToString() + "  [a.u]";

                Polarization_Ellipse.Instance.psi_label.Text = Math.Abs(stokes_params.get_psi_angle(true)).ToString() + " Degree";
                Polarization_Ellipse.Instance.chi_label.Text = stokes_params.get_chi_angle(true).ToString() + " Degree";
                Polarization_Ellipse.Instance.dop_label.Text = stokes_params.get_DOP().ToString() + " %";

                Functions.plot_ellipse(stokes_params.get_psi_angle(false), stokes_params.get_chi_angle(false));

                Polarization_Ellipse.Instance.DOP_Progress.Value = (int)stokes_params.get_DOP();

                double coord0 = stokes_params.get_S0();
                double coord1 = stokes_params.get_S1();
                double coord2 = stokes_params.get_S2();
                double coord3 = stokes_params.get_S3();

                coord1 = Math.Round(coord1 / coord0, 3);
                coord2 = Math.Round(coord2 / coord0, 3);
                coord3 = Math.Round(coord3 / coord0, 3);

                string stokes_msg = string.Format("= ({0}, {1}, {2})", coord1, coord2, coord3);

                double[] coordinates = new double[3] { coord1, coord2, coord3 };

                Poincare_Sphere.Instance.stokes_R.Text = stokes_msg;
                Poincare_Sphere.Instance.poincare3D.Visible = false;

                Global_variables.time_array_variable = time;
                Global_variables.intensity_array_variable = intensity;
                Global_variables.stokes_coordinates_variables = coordinates;

                MessageBox.Show("Simulation Finished!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_Gxx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_Gyy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_ReGxy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_ImGxy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
