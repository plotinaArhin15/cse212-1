public class Program
{
    public static void Main(string[] args)
    {
        var summary = SetsAndMaps.EarthquakeDailySummary();
        foreach (var item in summary)
        {
            Console.WriteLine(item);
        }
    }
}