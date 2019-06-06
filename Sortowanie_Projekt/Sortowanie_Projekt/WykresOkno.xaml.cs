using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Threading;
using System.Diagnostics;
using System.Windows.Controls.DataVisualization.Charting;
using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using LineSeries = LiveCharts.Wpf.LineSeries;
using Arction.Wpf.Charting;
using Arction.Wpf.Charting.Axes;
// LightningChartUltimate and general types.
using Arction.Wpf.Charting.SeriesXY;

namespace Sortowanie_Projekt
{
    /// <summary>
    /// Interaction logic for WykresOkno.xaml
    /// </summary>
    public partial class WykresOkno : Window
    {
        LightningChartUltimate chart = new LightningChartUltimate();
        AxisX axisX = new AxisX();
        AxisY axisY = new AxisY();
        public void RysujWykres(float[] times)
        {
                      var data = new SeriesPoint[times.Length];        
            var series = new PointLineSeries(chart.ViewXY, axisX, axisY);
            series.LineStyle.Color = Color.FromRgb(250, 0, 0);
            for (int i = 0; i < times.Length; i++)
            {
                data[i].X = i;
                data[i].Y = times[i];
            }
            series.Points = data;

            chart.ViewXY.PointLineSeries.Add(series);
            chart.ViewXY.ZoomToFit();
        }

        public WykresOkno()
        {
            InitializeComponent();

          
            (Content as Grid).Children.Add(chart);





        //    var rand = new Random();
           // int pointCounter = 16;


            /*var data = new SeriesPoint[pointCounter];
            for (int i = 0; i < pointCounter; i++)
            {
                data[i].X = (double)i;
                data[i].Y = rand.Next(0, 100);
            }

            var data2 = new SeriesPoint[pointCounter];

            for (int i = 0; i < pointCounter; i++)
            {
                data2[i].X = (double)i;
                data2[i].Y = Math.Sin(i * 0.2) * 50 + 50;
            }*/

            /*var series2 = new PointLineSeries(chart.ViewXY, chart.ViewXY.XAxes[0], chart.ViewXY.YAxes[0]);
            series2.LineStyle.Color = Color.FromArgb(255, 255, 67, 0);
            series2.LineStyle.Pattern = LinePattern.DashDot;
            series2.Title.Text = "Sinus data";

             axisX = chart.ViewXY.XAxes[0];
             axisY = chart.ViewXY.YAxes[0];

            var series = new PointLineSeries(chart.ViewXY, axisX, axisY);
            series.LineStyle.Color = Color.FromRgb(250, 0, 0);
            series2.Points = data2;

            series.Points = data;
            
            chart.ViewXY.PointLineSeries.Add(series2);*/
         
        }
    }
}
