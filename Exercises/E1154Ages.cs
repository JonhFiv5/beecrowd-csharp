using System.Globalization;

namespace GitHubFiles.Exercises;

class E1154Ages
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        
        int input, agesQtt = -1, agesSum = 0;
        double averageAge;
        
        do
        {
            input = int.Parse(Console.ReadLine());
            agesQtt++;
            agesSum += input;
        } while (input > 0);
        
        agesSum -= input;
        
        averageAge = (double) agesSum / agesQtt;
        
        Console.WriteLine($"{averageAge:N2}");

    }
}