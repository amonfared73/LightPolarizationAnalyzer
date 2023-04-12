using System;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Polarimeter
{
    public partial class Poincare_Sphere : UserControl
    {

        public static Poincare_Sphere _instance;
        public static Poincare_Sphere Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Poincare_Sphere();
                return _instance;
            }
        }

        public Label stokes_R
        {
            get
            {
                return this.label_stokescoordinate;
            }
        }

        public GLControl poincare3D
        {
            get
            {
                return this.glControl_poincare;
            }
        }

        public Poincare_Sphere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            glControl_poincare.Visible = true;
            float bgc = 0.9411f;
            GL.ClearColor(bgc, bgc, bgc, 1.0f);
            GL.Enable(EnableCap.DepthTest);

            GL.Viewport(0, 0, glControl_poincare.Width, glControl_poincare.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            float fovy = (float)Math.PI / 4;
            Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(fovy, glControl_poincare.Width / glControl_poincare.Height, 1.0f, 100.0f);
            GL.LoadMatrix(ref matrix);
            GL.MatrixMode(MatrixMode.Modelview);

            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.PushMatrix();
            GL.Translate(0.0, 0.0, -3.0);
            GL.Rotate(45.0, 0.0, 0.0, 1.0);
            GL.Rotate(55.0, -1.0, 1.0, 0.0);
            GL.Rotate(180.0, 0.0, 0.0, 1.0);

            Functions.draw_sphere(true, 1);
            //Functions.drawX();
            //Functions.drawY();
            double[] stokes = new double[3] { Global_variables.stokes_coordinates_variables[0], Global_variables.stokes_coordinates_variables[1], Global_variables.stokes_coordinates_variables[2] };
            Functions.draw_line(stokes);

            //IntPtr imageData = (IntPtr)(320 * 320 * (3));
            //Bitmap image_bmp = new Bitmap(320, 320);
            //GL.ReadPixels(0, 0, 320, 320, PixelFormat.Red, PixelType.Bitmap, imageData);

            //for (int i = 0; i < 320; i++)
            //{
            //    for (int j = 0; j < 320; j++)
            //    {
            //        image_bmp.SetPixel(i, j);
            //    }
            //}

            glControl_poincare.SwapBuffers();
        }
    }
}
