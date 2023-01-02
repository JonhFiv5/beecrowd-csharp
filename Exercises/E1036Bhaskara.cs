using System.Globalization;

namespace GitHubFiles.Exercises;

class E1036Bhaskara
{
    public static void Run()
    {
        string[] input;
        double a, b, c, delta, x01, x02;
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        input = Console.ReadLine().Split(" ");
        a = double.Parse(input[0]);
        b = double.Parse(input[1]);
        c = double.Parse(input[2]);

        delta = b * b - 4 * a * c;

        if (a == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            x01 = Math.Round((- b + Math.Sqrt(delta)) / (2 * a), 5);
            x02 = Math.Round((- b - Math.Sqrt(delta)) / (2 * a), 5);

            string format = "0.00000";
            Console.WriteLine("R1 = {0}\nR2 = {1}", x01.ToString(format), x02.ToString(format));
        }
    }
}