using System.Globalization;

namespace GitHubFiles.Exercises;

class E1182ColumnInArray
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        
        int selectedColumn;
        char operation;
        double[,] numbers = new double[12, 12];
        double result = 0;
        
        selectedColumn = int.Parse(Console.ReadLine());
        operation = char.Parse(Console.ReadLine());
        
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                numbers[i, j] = double.Parse(Console.ReadLine());
            }
        }
        
        for (int i = 0; i < 12; i++)
        {
            result += numbers[i, selectedColumn];
        }
        
        if (operation == 'M')
        {
            result = result / 12;
        }
        
        Console.WriteLine($"{result:N1}");

    }
}