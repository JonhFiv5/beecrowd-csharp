using System.Globalization;

namespace GitHubFiles.Exercises;

class E1079WeightedAverages
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        int totalTests;
        string[] input;
        double numA, numB, numC, average;

        totalTests = int.Parse(Console.ReadLine());

        for (int i = 0; i < totalTests; i++)
        {
            input = Console.ReadLine().Split(" ");
            
            numA = double.Parse(input[0]);
            numB = double.Parse(input[1]);
            numC = double.Parse(input[2]);
            average = (numA * 2 + numB * 3 + numC * 5) / 10.0;
            
            Console.WriteLine(average.ToString("0.0"));
        }
    }
}