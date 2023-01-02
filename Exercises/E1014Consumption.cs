using System.Globalization;


namespace GitHubFiles.Exercises;

class E1014Consumption
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        int distance;
        double spentFuel, averageConsumption;

        distance = int.Parse(Console.ReadLine());
        spentFuel = double.Parse(Console.ReadLine());

        averageConsumption = Math.Round(distance / spentFuel, 3);

        Console.WriteLine("{0} km/l", averageConsumption.ToString("0.000"));
    }
}