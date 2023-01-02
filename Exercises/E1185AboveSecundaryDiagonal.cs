using System.Globalization;
namespace GitHubFiles.Exercises;

class E1185AboveSecundaryDiagonal
{
    public static void Run()
    {
        
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        
        const int LINE_LENGTH = 12;
        const int COLUMN_LENGTH = 12;
        double[,] numbers = new double[LINE_LENGTH, COLUMN_LENGTH];
        double result = 0;
        char operation;
        int qtt = 0;
        
        operation = char.Parse(Console.ReadLine());
        
        for (int i = 0; i < LINE_LENGTH; i++)
        {
            for (int j = 0; j < COLUMN_LENGTH; j++)
            {
                numbers[i, j] = double.Parse(Console.ReadLine());
                if (j < (COLUMN_LENGTH - 1 - i))
                {
                    result += numbers[i, j];
                    qtt++;
                }
            }
        }
        
        if (operation == 'M')
        {
            result = result / qtt;
        }
        
        Console.WriteLine(result.ToString("0.0"));

    }
}