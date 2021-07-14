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
        string lines;
        public Chart()
        {
            InitializeComponent();
            //lấy file log
            DateTime date = DateTime.Now;
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                + @"\MeasureCO2Desktop" + @"\log_" + date.Day + "_" + date.Month + "_" + date.Year + ".txt";
            //string filepath = "D:\\log_" + date.Day + "_" + date.Month + "_" + date.Year + ".txt";
            FileStream f = new FileStream(filePath, FileMode.OpenOrCreate);
            StreamReader sw = new StreamReader(f);
            //tạo thông số cho biểu đồ
            DateTime dt = DateTime.Today;

            //while (sw.ReadLine() != null)
            //{ lines = Convert.ToDouble(sw.ReadLine()); }

            var chart = chart1.ChartAreas[0];
            //chart.AxisX.LabelStyle.Format = "hh:mm:ss";

            //Axis Y
            chart.AxisY.Maximum = 2000;
            chart.AxisY.Minimum = 1100;
            chart.AxisY.Interval = 100;
            chart.AxisY.Title = "CO2 PPM";
            chart.AxisY.MajorGrid.Interval = 100;
            chart.AxisY.LabelStyle.Interval = 100;
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
            //live map
            //    var mapper = Mappers.Xy<MeasureModel>()
            //        .X(model => model.DateTime.Ticks)
            //        .Y(model => model.Value);


            //    Charting.For<MeasureModel>(mapper);
            //    ChartValues = new ChartValues<MeasureModel>();
            //    cartesianChart1.Series = new SeriesCollection
            //    {
            //        new LineSeries
            //        {
            //            Values = ChartValues,
            //            PointGeometrySize=10,
            //            StrokeThickness=2
            //        }  
            //    };

            //    cartesianChart1.AxisX.Add(new Axis
            //    {
            //        LabelFormatter =value => new DateTime((long)value).ToString("hh:mm:ss"),
            //        Separator = new Separator
            //        {
            //            Step = TimeSpan.FromSeconds(1).Ticks
            //        }
            //    });
            //    SetAxisLimits(date);
            //    Timer = new Timer
            //    {
            //        Interval = 500
            //    };
            //    Timer.Tick += TimeOnTick;
            //    R = lines;
            //    Timer.Start();
            //}

            //ChartValues<MeasureModel> ChartValues { get; set; }
            //public Timer Timer { get; set; }
            //public double R { get; set; }
            //private void SetAxisLimits(DateTime now)
            //{
            //    cartesianChart1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(10).Ticks;
            //    cartesianChart1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks;
            //}
            //private void TimeOnTick(object sender, EventArgs e)
            //{

            //    var now = DateTime.Now;
            //    ChartValues.Add(new MeasureModel
            //    {
            //        DateTime = now,
            //        Value = R
            //    });
            //    SetAxisLimits(now);
            //    if(ChartValues.Count>=30)
            //    {
            //        ChartValues.RemoveAt(0);
            //    }
            //}

        }
    }
}
