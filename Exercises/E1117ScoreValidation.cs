using System.Globalization;

namespace GitHubFiles.Exercises;

class E1117ScoreValidation
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        List<double> grades = new List<double>();
        double input;

        while (true)
        {
            input = double.Parse(Console.ReadLine());
            if (input >= 0 && input <= 10)
            {
                grades.Add(input);
                if (grades.Count() == 2)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("nota invalida");
            }
        }

        Console.WriteLine($"media = {grades.Average():N2}");
    }
}