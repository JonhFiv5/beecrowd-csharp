using System.Globalization;

namespace GitHubFiles.Exercises;

class E1116DividingXByY
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        string[] input;
        int iterations, x, y;
        double quotient;

        iterations = int.Parse(Console.ReadLine());

        for (int i = 0; i < iterations; i++)
        {
            input = Console.ReadLine().Split(" ");
            x = int.Parse(input[0]);
            y = int.Parse(input[1]);
            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                quotient = x / (double) y;
                Console.WriteLine($"{quotient:N1}");
            }
        }
    }
}