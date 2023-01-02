using System.Globalization;

namespace GitHubFiles.Exercises;

class E1178ArrayFill03
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        
        double[] numbers = new double[100];
        double startingNumber;
        
        startingNumber = double.Parse(Console.ReadLine());
        numbers[0] = startingNumber;
        
        for (int i = 1; i < 100; i++)
        {
            numbers[i] = numbers[i-1] / 2.0;
        }
        
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"N[{i}] = {numbers[i]:N4}");
        }

    }
}