using OxyPlot;
using OxyPlot.Series;

namespace OxyPlotTest
{
    public class PieChart
    {
        public PlotModel Model { get; private set; }

        public PieChart()
        {
            this.Model = new PlotModel { Title = "PieChart" };
            var data = new PieSeries { StrokeThickness = 0.8, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 270 };
            data.Slices.Add(new PieSlice("Soy Sauce", 30) { IsExploded = true });
            data.Slices.Add(new PieSlice("Miso", 20) { IsExploded = true });
            data.Slices.Add(new PieSlice("Solt", 15) { IsExploded = true });
            data.Slices.Add(new PieSlice("Pork Broth", 10) { IsExploded = true });
            data.Slices.Add(new PieSlice("Seaweed", 5) { IsExploded = true });
            data.Slices.Add(new PieSlice("Other", 3) { IsExploded = true });
            Model.Series.Add(data);
        }
    }
}
