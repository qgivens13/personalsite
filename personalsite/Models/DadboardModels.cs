namespace personalsite.Models;

public class DadStat
{
    public string Title { get; set; } = string.Empty;
    public int Value { get; set; }
    public string Unit { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Trend { get; set; } = string.Empty; // "up" or "down"
    public string TrendLabel { get; set; } = string.Empty;
}

public class MeltdownCategory
{
    public string Category { get; set; } = string.Empty;
    public int Count { get; set; }
    public string Color { get; set; } = string.Empty;
}

public class SleepDataPoint
{
    public string Date { get; set; } = string.Empty;
    public double Hours { get; set; }
}

public class DadboardData
{
    public List<DadStat> Stats { get; set; } = new();
    public List<MeltdownCategory> Meltdowns { get; set; } = new();
    public List<SleepDataPoint> SleepData { get; set; } = new();
}

