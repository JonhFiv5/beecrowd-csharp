using System.Globalization;
namespace GitHubFiles.Exercises;

class E1183AboveMainDiagonal
{
    public static void Run()
    {
        
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        
        double[,] numbers = new double[12, 12];
        char operation;
        double result = 0;
        int qtt = 0;
        
        operation = char.Parse(Console.ReadLine());
        
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                numbers[i, j] = double.Parse(Console.ReadLine());
        
                if (j > i)
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