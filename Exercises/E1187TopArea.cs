using System.Globalization;

namespace GitHubFiles.Exercises;

class E1187TopArea
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        
        const int LINES = 12, COLUMNS = 12, LAST_POSITION = 11;
        
        double[,] numbers = new double[12, 12];
        char operation;
        double result = 0;
        int qtt = 0;
        
        operation = char.Parse(Console.ReadLine());
        
        for (int line = 0; line < LINES; line++)
        {
            for (int column = 0; column < COLUMNS; column++)
            {
                numbers[line, column] = double.Parse(Console.ReadLine());
        
                if ((column > line) && (column < (LAST_POSITION - line)))
                {
                    result += numbers[line, column];
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