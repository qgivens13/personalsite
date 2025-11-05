using personalsite.Models;

namespace personalsite.Services;

public interface IDadboardService
{
    Task<DadboardData> GetDadboardDataAsync();
}

public class DadboardService : IDadboardService
{
    public Task<DadboardData> GetDadboardDataAsync()
    {
        // Mock dad humor data - easily replaceable with real data sources
        var data = new DadboardData
        {
            Stats = new List<DadStat>
            {
                new DadStat
                {
                    Title = "Total Diapers Changed",
                    Value = 2847,
                    Unit = "diapers",
                    Icon = "🚼",
                    Trend = "up",
                    TrendLabel = "+3 today"
                },
                new DadStat
                {
                    Title = "Sleepless Nights",
                    Value = 487,
                    Unit = "nights",
                    Icon = "😴",
                    Trend = "down",
                    TrendLabel = "Finally improving"
                },
                new DadStat
                {
                    Title = "Coffees Consumed",
                    Value = 1893,
                    Unit = "cups",
                    Icon = "☕",
                    Trend = "up",
                    TrendLabel = "+47 this week"
                },
                new DadStat
                {
                    Title = "Toy Landmines Stepped On",
                    Value = 612,
                    Unit = "casualties",
                    Icon = "🧸",
                    Trend = "up",
                    TrendLabel = "It never ends"
                },
                new DadStat
                {
                    Title = "Dad Jokes Told",
                    Value = 3421,
                    Unit = "groaners",
                    Icon = "🤣",
                    Trend = "up",
                    TrendLabel = "Peak performance"
                },
                new DadStat
                {
                    Title = "Snacks Prepared",
                    Value = 5234,
                    Unit = "servings",
                    Icon = "🍎",
                    Trend = "up",
                    TrendLabel = "They're always hungry"
                },
                new DadStat
                {
                    Title = "Minutes of Listening to Elmo in the Car",
                    Value = 892,
                    Unit = "minutes",
                    Icon = "🎵",
                    Trend = "up",
                    TrendLabel = "Chart-topping"
                },
                new DadStat
                {
                    Title = "Minutes of Personal Time",
                    Value = 37,
                    Unit = "minutes",
                    Icon = "⏱️",
                    Trend = "down",
                    TrendLabel = "This month"
                }
            },
            
            Meltdowns = new List<MeltdownCategory>
            {
                new MeltdownCategory { Category = "Told no by dad", Count = 147, Color = "#6366F1" },
                new MeltdownCategory { Category = "Told no by mom", Count = 231, Color = "#8B5CF6" },
                new MeltdownCategory { Category = "Told yes, but still cried", Count = 457, Color = "#EC4899" },
                new MeltdownCategory { Category = "Bath time", Count = 67, Color = "#10B981" },
                new MeltdownCategory { Category = "No reason", Count = 423, Color = "#EF4444" }
            },
            
            SleepData = GenerateSleepData()
        };

        return Task.FromResult(data);
    }

    private static List<SleepDataPoint> GenerateSleepData()
    {
        // Generate last 14 days of sleep data with realistic sleep patterns
        var data = new List<SleepDataPoint>();
        var random = new Random(42); 
        var today = DateTime.Today;

        for (int i = 13; i >= 0; i--)
        {
            var date = today.AddDays(-i);
            var hours = 4.0 + (random.NextDouble() * 2.5);
            if (random.Next(10) == 0) 
                hours = 6.5 + (random.NextDouble() * 0.5);

            data.Add(new SleepDataPoint
            {
                Date = date.ToString("MM/dd"),
                Hours = Math.Round(hours, 1)
            });
        }

        return data;
    }
}

