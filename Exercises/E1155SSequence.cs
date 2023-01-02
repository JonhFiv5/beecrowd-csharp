using System.Globalization;

namespace GitHubFiles.Exercises;

class E1155SSequence
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        double s = 0;
        
        for (int i = 1; i <= 100; i++)
        {
            s += (double) 1 / i;
        }
        
        Console.WriteLine($"{s:N2}");

    }
}