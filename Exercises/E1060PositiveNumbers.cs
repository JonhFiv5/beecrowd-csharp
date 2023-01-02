using System.Globalization;

namespace GitHubFiles.Exercises;

class E1060PositiveNumbers
{
    public static void Run()
    {
        float input;
        int evenCount = 0;

        for (int i = 0; i < 6; i++)
        {
            input = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (input > 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine("{0} valores positivos", evenCount);
    }
}