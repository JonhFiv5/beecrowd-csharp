using System.Globalization;

namespace GitHubFiles.Exercises;

class E1174ArraySelection01
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        
        const int SIZE = 5;
        double[] arrayInput = new double[SIZE];
        int?[] selectedArrayPositions = new int?[SIZE];
        
        for (int i = 0; i < SIZE; i++)
        {
            arrayInput[i] = double.Parse(Console.ReadLine());
        
            if (arrayInput[i] <= 10)
            {
                selectedArrayPositions[i] = i;
            }
            else
            {
                selectedArrayPositions[i] = null;
            }
        }
        
        foreach (int? position in selectedArrayPositions)
        {
            if(position != null)
            {
                Console.WriteLine($"A[{position}] = {arrayInput[(int)position]:N1}");
            }
        }

    }
}