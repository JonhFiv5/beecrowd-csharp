using System.Globalization;

namespace GitHubFiles.Exercises;

class E1181LineInArray
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        
        double[,] numbers = new double[12,12];
        int line;
        char operation;
        double result = 0;
        
        line = int.Parse(Console.ReadLine());
        operation = char.Parse(Console.ReadLine());
        
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                numbers[i,j] = double.Parse(Console.ReadLine());
            }
        }
        
        for (int i = 0; i < 12; i++)
        {
            result += numbers[line,i];
        }
        
        if (operation == 'M')
        {
            result = result / 12.0;
        }
        
        Console.WriteLine(result.ToString("0.0"));

    }
}