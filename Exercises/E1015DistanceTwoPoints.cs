using System.Globalization;


namespace GitHubFiles.Exercises;

class E1015DistanceTwoPoints
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        string[] input;
        double x1, x2, y1, y2, result;

        input = Console.ReadLine().Split(" ");
        x1 = double.Parse(input[0]);
        y1 = double.Parse(input[1]);

        input = Console.ReadLine().Split(" ");
        x2 = double.Parse(input[0]);
        y2 = double.Parse(input[1]);

        result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        result = Math.Round(result, 4);

        Console.WriteLine(result.ToString("0.0000"));
    }
}