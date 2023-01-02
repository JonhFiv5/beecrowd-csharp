using System.Globalization;

namespace GitHubFiles.Exercises;

class E1048SalaryIncrease
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        float salary, newSalary;
        int earnedPercentage;

        salary = float.Parse(Console.ReadLine());

        if (salary >= 0 && salary <= 400)
        {
            earnedPercentage = 15;
        }
        else if (salary > 400 && salary <= 800)
        {
            earnedPercentage = 12;
        }
        else if (salary > 800 && salary <= 1200)
        {
            earnedPercentage = 10;
        }
        else if (salary > 1200 && salary <= 2000)
        {
            earnedPercentage = 7;
        }
        else
        {
            earnedPercentage = 4;
        }

        newSalary = salary * (1 + earnedPercentage / 100.0f);

        Console.WriteLine($"Novo Salario: {newSalary.ToString("0.00")}\n" +
                $"Reajuste ganho: {(newSalary - salary).ToString("0.00")}\n" +
                $"Em percentual: {earnedPercentage} %");

    }
}