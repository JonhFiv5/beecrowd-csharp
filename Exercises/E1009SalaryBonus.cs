using System.Globalization;

namespace GitHubFiles.Exercises;

class E1009SalaryBonus
{
    public static void Run()
    {
        string employeeName;
        double salary, monthSales, bonus;

        employeeName = Console.ReadLine();
        salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        monthSales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        bonus = monthSales * 0.15;
        salary += bonus;
        salary = Math.Round(salary, 2);

        Console.WriteLine("TOTAL = R$ {0}", salary.ToString("0.00", CultureInfo.InvariantCulture));
    }
}