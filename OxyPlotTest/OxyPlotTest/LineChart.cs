using OxyPlot;
using OxyPlot.Series;

namespace OxyPlotTest
{
    public class LineChart
    {
        public PlotModel Model { get; private set; }

        public LineChart()
        {
            this.Model = new PlotModel { Title = "LineChart" };

            var X_line = new LineSeries();
            X_line.Color = OxyColors.Red;
            X_line.Points.Add(new DataPoint(0, 0));
            X_line.Points.Add(new DataPoint(1, 4));
            X_line.Points.Add(new DataPoint(2, 1));
            X_line.Points.Add(new DataPoint(3, 3));
            Model.Series.Add(X_line);

            var Y_line = new LineSeries();
            Y_line.Color = OxyColors.Blue;
            Y_line.Points.Add(new DataPoint(0, 0));
            Y_line.Points.Add(new DataPoint(1, 2));
            Y_line.Points.Add(new DataPoint(2, 0));
            Y_line.Points.Add(new DataPoint(3, 6));
            Model.Series.Add(Y_line);
        }
    }
}
