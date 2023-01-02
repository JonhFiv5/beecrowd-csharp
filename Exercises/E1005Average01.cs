using System.Globalization;

namespace GitHubFiles.Exercises;

class E1005Average01
{
    public static void Run()
    {
        double a, b, average;
        const double WEIGHT_A = 3.5;
        const double WEIGHT_B = 7.5;

        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        average = ((a * WEIGHT_A) + (b * WEIGHT_B)) / (WEIGHT_A + WEIGHT_B);

        Console.WriteLine("MEDIA = {0}", average.ToString("N5", CultureInfo.InvariantCulture));
    }
}