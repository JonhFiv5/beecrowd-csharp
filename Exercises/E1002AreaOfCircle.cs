using System.Globalization;

namespace GitHubFiles.Exercises;

class E1002AreaOfCircle
{
    public static void Run()
    {
        const double PI = 3.14159;
        double radius, area;

        radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = PI * (radius * radius);
        Console.Write("A=" + area.ToString("0.0000", CultureInfo.InvariantCulture));
    }
}