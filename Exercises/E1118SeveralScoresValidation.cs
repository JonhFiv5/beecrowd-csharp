using System.Globalization;

namespace GitHubFiles.Exercises;

class E1118SeveralScoresValidation
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        List<double> grades = new List<double>();
        double input;
        int choice;

        while (true)
        {
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

            do
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                choice = int.Parse(Console.ReadLine());
            } while (choice < 1 || choice > 2);

            if (choice == 2)
            {
                break;
            }

            grades.Clear();
        }
    }
}