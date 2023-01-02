using System.Globalization;

namespace GitHubFiles.Exercises;

class E1037Interval
{
    public static void Run()
    {
        double input;
        string message;

        input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (input >= 0 && input <= 25)
        {
            message = "Intervalo [0,25]";
        }
        else if (input > 25 && input <= 50)
        {
            message = "Intervalo (25,50]";
        }
        else if (input > 50 && input <= 75)
        {
            message = "Intervalo (50,75]";
        }
        else if (input > 75 && input <= 100)
        {
            message = "Intervalo (75,100]";
        }
        else
        {
            message = "Fora de intervalo";
        }

        Console.WriteLine(message);

    }
}