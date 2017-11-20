using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Collections.Generic;

namespace OxyPlotTest
{
    public class BarChart
    {
        public PlotModel Model { get; private set; }

        public BarChart()
        {
            this.Model = new PlotModel { Title = "BarChart" };

            var data = new BarSeries();
            var barList = new List<BarItem>();
            barList.Add(new BarItem(35));
            barList.Add(new BarItem(25));
            barList.Add(new BarItem(40));
            data.ItemsSource = barList;
            this.Model.Series.Add(data);

            var axes = new CategoryAxis();
            var axesList = new List<string>();
            axesList.Add("kiyotaka");
            axesList.Add("carlos");
            axesList.Add("omegatribe");
            axes.ItemsSource = axesList;
            axes.Position = AxisPosition.Left;
            this.Model.Axes.Add(axes);
        }
    }
}
