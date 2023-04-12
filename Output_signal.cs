using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.Drawing.Chart;

namespace Polarimeter
{
    public partial class Output_signal : UserControl
    {

        public static Output_signal _instance;
        public static Output_signal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Output_signal();
                return _instance;
            }
        }
        public Chart Signal_Chart
        {
            get
            {
                return this.chart_signal;
            }
        }

        public Chart FFT_Chart
        {
            get
            {
                return this.chart_fft;
            }
        }

        public Output_signal()
        {
            InitializeComponent();
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            if (Global_variables.intensity_array_variable != null) {
                CreateSpreadsheet();
                MessageBox.Show("Excel file exported successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nothing to export!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreateSpreadsheet()
        {
            string spreadsheetPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/output_signal.xlsx";
            File.Delete(spreadsheetPath);
            FileInfo spreadsheetInfo = new FileInfo(spreadsheetPath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage pck = new ExcelPackage(spreadsheetInfo);
            var signal_worksheet = pck.Workbook.Worksheets.Add("Output Signal");
            signal_worksheet.View.FreezePanes(2, 1);
            signal_worksheet.Cells["A1"].Value = "Time [s]";
            signal_worksheet.Cells["B1"].Value = "Intensity [a.u]";
            signal_worksheet.Cells["A1:B1"].AutoFitColumns();
            signal_worksheet.Cells["A1:B1"].Style.Font.Bold = true;

            int L = Global_variables.time_array_variable.Length;
            int start_row = 2;
            for (int i = 0; i < L; i++)
            {
                int num = start_row + i;
                signal_worksheet.Cells["A" + num.ToString()].Value = Global_variables.time_array_variable[i];
                signal_worksheet.Cells["B" + num.ToString()].Value = Global_variables.intensity_array_variable[i];
            }

            ExcelChart output_chart = signal_worksheet.Drawings.AddChart("Output Signal", eChartType.Line) as ExcelLineChart;
            output_chart.Title.Text = "Output Signal";
            output_chart.SetPosition(1, 0, 3, 0);
            output_chart.SetSize(800, 300);
            var time = signal_worksheet.Cells["A2:A" + (L + start_row - 1).ToString()];
            var intensity = signal_worksheet.Cells["B2:B" + (L + start_row - 1).ToString()];
            output_chart.Legend.Remove();
            output_chart.Series.Add(intensity, time);

            pck.Save();
        }
    }
}
