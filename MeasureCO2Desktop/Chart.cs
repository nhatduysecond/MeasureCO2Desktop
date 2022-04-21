using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.IO;

namespace MeasureCO2Desktop
{
    public partial class Chart : Form
    {
        string lines, linePM25, linePM10;
        public Chart()
        {
            InitializeComponent();
            //lấy file log
            DateTime date = DateTime.Now;
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                + @"\MeasureCO2Desktop" + @"\log_" + date.Day + "_" + date.Month + "_" + date.Year + ".txt";

            string filePathBuiPM25 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                +@"\MeasureCO2Desktop" + @"\log_" + date.Day + "_" + date.Month + "_" + date.Year + "_25.txt";

            string filePathBuiPM10 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                + @"\MeasureCO2Desktop" + @"\log_" + date.Day + "_" + date.Month + "_" + date.Year + "_10.txt";


            FileStream f = new FileStream(filePath, FileMode.OpenOrCreate);
            StreamReader sw = new StreamReader(f);

            FileStream fBuiPM25 = new FileStream(filePathBuiPM25, FileMode.OpenOrCreate);
            StreamReader swBuiPM25 = new StreamReader(fBuiPM25);

            FileStream fBuiPM10 = new FileStream(filePathBuiPM10, FileMode.OpenOrCreate);
            StreamReader swBuiPM10 = new StreamReader(fBuiPM10);
            //tạo thông số cho biểu đồ
            DateTime dt = DateTime.Today;

            var chart = chart1.ChartAreas[0];
            var chartBuiPm25 = chartBuiPM25.ChartAreas[0];
            var chartBuiPm10 = chartBuiPM10.ChartAreas[0];


            #region charCO2
            //Axis Y
            chart.AxisY.Maximum = 200;
            chart.AxisY.Minimum = 10;
            chart.AxisY.Interval = 10;
            chart.AxisY.Title = "CO2 PPM";
            chart.AxisY.MajorGrid.Interval = 10;
            chart.AxisY.LabelStyle.Interval = 10;
            //Axis X
            //chart.AxisX.IntervalAutoMode=IntervalAutoMode.VariableCount;
            chart.AxisX.Title = "Thời gian";
            chart.AxisX.Minimum = dt.AddHours(0).ToOADate();
            chart.AxisX.Maximum = dt.AddHours(23.9).ToOADate();
            chart.AxisX.Interval = 1;
            chart.AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Hours;
            chart.AxisX.MajorGrid.Interval = 1;
            chart.AxisX.IntervalType = DateTimeIntervalType.Hours;
            chart.AxisX.LabelStyle.Format = "hh:mm";
            chart.AxisX.LabelStyle.Interval = 1;

            chart1.Series.Add("ppm");
            //chart1.Series["ppm"].ChartType = SeriesChartType.Line;
            chart1.Series["ppm"].ChartType = SeriesChartType.Spline;
            chart1.Series["ppm"].Color = Color.Red;
            chart1.Series["ppm"].IsVisibleInLegend = true;
            chart1.Series[0].IsVisibleInLegend = false;
            //bắt đầu vẽ theo file log
            long i = 0;
            while ((lines = sw.ReadLine()) != null)
            {
                chart1.Series["ppm"].Points.AddXY(dt.AddMinutes(i).ToOADate(), lines);
                i+=4;
                //điều chỉnh system nhận data về 5p/lần
            }
            f.Close();
            #endregion

            //chart bụi
            #region ChartBuiPM25
            //Axis Y
            chartBuiPm25.AxisY.Maximum = 100;
            chartBuiPm25.AxisY.Minimum = 1;
            chartBuiPm25.AxisY.Interval = 10;
            chartBuiPm25.AxisY.Title = "nồng độ bụi PM2.5 (g/m3)";
            chartBuiPm25.AxisY.MajorGrid.Interval = 10;
            chartBuiPm25.AxisY.LabelStyle.Interval = 10;
            //Axis X
            //chart.AxisX.IntervalAutoMode=IntervalAutoMode.VariableCount;
            chartBuiPm25.AxisX.Title = "Thời gian";
            chartBuiPm25.AxisX.Minimum = dt.AddHours(0).ToOADate();
            chartBuiPm25.AxisX.Maximum = dt.AddHours(23.9).ToOADate();
            chartBuiPm25.AxisX.Interval = 1;
            chartBuiPm25.AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Hours;
            chartBuiPm25.AxisX.MajorGrid.Interval = 1;
            chartBuiPm25.AxisX.IntervalType = DateTimeIntervalType.Hours;
            chartBuiPm25.AxisX.LabelStyle.Format = "hh:mm";
            chartBuiPm25.AxisX.LabelStyle.Interval = 1;

            chartBuiPM25.Series.Add("g/m3");
            //chart1.Series["ppm"].ChartType = SeriesChartType.Line;
            chartBuiPM25.Series["g/m3"].ChartType = SeriesChartType.Spline;
            chartBuiPM25.Series["g/m3"].Color = Color.Red;
            chartBuiPM25.Series["g/m3"].IsVisibleInLegend = true;
            chartBuiPM25.Series[0].IsVisibleInLegend = false;
            //bắt đầu vẽ theo file log
            long j = 0;
            while ((linePM25 = swBuiPM25.ReadLine()) != null)
            {
                chartBuiPM25.Series["g/m3"].Points.AddXY(dt.AddMinutes(j).ToOADate(), linePM25);
                j += 4;
                //điều chỉnh system nhận data về 5p/lần
            }
            fBuiPM25.Close();
            #endregion

            #region ChartBuiPM25
            //Axis Y
            chartBuiPm10.AxisY.Maximum = 100;
            chartBuiPm10.AxisY.Minimum = 1;
            chartBuiPm10.AxisY.Interval = 10;
            chartBuiPm10.AxisY.Title = "nồng độ bụi PM10 (g/m3)";
            chartBuiPm10.AxisY.MajorGrid.Interval = 10;
            chartBuiPm10.AxisY.LabelStyle.Interval = 10;
            //Axis X
            //chart.AxisX.IntervalAutoMode=IntervalAutoMode.VariableCount;
            chartBuiPm10.AxisX.Title = "Thời gian";
            chartBuiPm10.AxisX.Minimum = dt.AddHours(0).ToOADate();
            chartBuiPm10.AxisX.Maximum = dt.AddHours(23.9).ToOADate();
            chartBuiPm10.AxisX.Interval = 1;
            chartBuiPm10.AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Hours;
            chartBuiPm10.AxisX.MajorGrid.Interval = 1;
            chartBuiPm10.AxisX.IntervalType = DateTimeIntervalType.Hours;
            chartBuiPm10.AxisX.LabelStyle.Format = "hh:mm";
            chartBuiPm10.AxisX.LabelStyle.Interval = 1;

            chartBuiPM10.Series.Add("g/m3");
            //chart1.Series["ppm"].ChartType = SeriesChartType.Line;
            chartBuiPM10.Series["g/m3"].ChartType = SeriesChartType.Spline;
            chartBuiPM10.Series["g/m3"].Color = Color.Red;
            chartBuiPM10.Series["g/m3"].IsVisibleInLegend = true;
            chartBuiPM10.Series[0].IsVisibleInLegend = false;
            //bắt đầu vẽ theo file log
            long k = 0;
            while ((linePM10 = swBuiPM10.ReadLine()) != null)
            {
                chartBuiPM10.Series["g/m3"].Points.AddXY(dt.AddMinutes(k).ToOADate(), linePM10);
                k += 4;
                //điều chỉnh system nhận data về 5p/lần
            }
            fBuiPM10.Close();
            #endregion

        }
    }
}
