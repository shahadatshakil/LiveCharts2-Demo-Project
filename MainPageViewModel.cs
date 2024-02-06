using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;

namespace BarChartInconsistency;

public class MainPageViewModel
{
    public ISeries[] Series { get; set; } =
    {
        new ColumnSeries<DateTimePoint>
        {
            Values =
            [
                new DateTimePoint(new DateTime(2000,1,1,1,1,1), 5),
                new DateTimePoint(new DateTime(2000,1,1,1,1,4), 3),
                new DateTimePoint(new DateTime(2000,1,1,1,1,10), 7),
                new DateTimePoint(new DateTime(2000,1,1,1,1,14), 2),
                new DateTimePoint(new DateTime(2000,1,1,1,1,18), 10),
            ]
        },
    };

    public Axis[] XAxes { get; set; } =
    {
        new DateTimeAxis(TimeSpan.FromSeconds(5), date => date.ToString("hh:mm:ss"))
        {
            MinLimit = new DateTime(2000,1,1,1,1,1).Ticks,
            MaxLimit = new DateTime(2000,1,1,1,1,20).Ticks,
        }
    };

    public Axis[] YAxes { get; set; } =
    {
        new Axis
        {
            MinLimit = 0,
            MaxLimit = 10
        }
    };
}
