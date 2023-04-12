using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polarimeter
{
    class Global_variables
    {
        private static double[] time_array;
        public static double[] time_array_variable
        {
            get
            {
                return time_array;
            }
            set
            {
                time_array = value;
            }
        }

        private static double[] intensity_array;
        public static double[] intensity_array_variable
        {
            get
            {
                return intensity_array;
            }
            set
            {
                intensity_array = value;
            }
        }

        private static double[] stokes_coordinates;
        public static double[] stokes_coordinates_variables
        {
            get
            {
                return stokes_coordinates;
            }
            set
            {
                stokes_coordinates = value;
            }
        }
    }
}
