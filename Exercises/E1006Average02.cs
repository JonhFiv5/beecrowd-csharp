using System.Globalization;

namespace GitHubFiles.Exercises;

class E1006Average02
{
    public static void Run()
    {
        double a, b, c, average;
        const double WEIGHT_A = 2;
        const double WEIGHT_B = 3;
        const double WEIGHT_C = 5;

        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        average = (a * WEIGHT_A + b * WEIGHT_B + c * WEIGHT_C) / (WEIGHT_A + WEIGHT_B + WEIGHT_C);

        Console.WriteLine("MEDIA = {0}", average.ToString("N1", CultureInfo.InvariantCulture));
    }
}