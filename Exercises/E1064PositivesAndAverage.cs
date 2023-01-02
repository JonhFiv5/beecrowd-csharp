using System.Globalization;

namespace GitHubFiles.Exercises;

class E1064PositivesAndAverage
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        double number, average, totalSum = 0, positiveCount = 0;

        for (int i = 0; i < 6; i ++)
        {
            number = double.Parse(Console.ReadLine());
            if (number > 0)
            {
                positiveCount++;
                totalSum += number;
            }
        }

        average = totalSum / positiveCount;
        Console.WriteLine("{0} valores positivos\n{1}", positiveCount, average.ToString("0.0"));
    }
}