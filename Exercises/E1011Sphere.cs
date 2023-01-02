using System.Globalization;

namespace GitHubFiles.Exercises;

class E1011Sphere
{
    public static void Run()
    {
        const double PI = 3.14159;
        double radius, volume;

        radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        volume = 4/3.0 * PI * Math.Pow(radius, 3);
        volume = Math.Round(volume, 3);

        Console.WriteLine("VOLUME = {0}", volume.ToString(CultureInfo.InvariantCulture));
    }
}