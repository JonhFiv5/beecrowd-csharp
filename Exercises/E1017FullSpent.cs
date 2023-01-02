using System.Globalization;

namespace GitHubFiles.Exercises;

class E1017FullSpent
{
    public static void Run()
    {
        int time, averageSpeed, distance;
        double fuelSpent;

        time = int.Parse(Console.ReadLine());
        averageSpeed = int.Parse(Console.ReadLine());

        distance = averageSpeed * time;
        fuelSpent = Math.Round((distance / 12.0), 3);

        Console.WriteLine(fuelSpent.ToString("0.000", CultureInfo.InvariantCulture));
    }
}