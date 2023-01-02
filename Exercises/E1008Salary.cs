using System.Globalization;

namespace GitHubFiles.Exercises;

class E1008Salary
{
    public static void Run()
    {
        int employeeNumber, monthlyHours;
        double amountHour, salary;

        employeeNumber = int.Parse(Console.ReadLine());
        monthlyHours = int.Parse(Console.ReadLine());
        amountHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salary = monthlyHours * amountHour;

        Console.WriteLine("NUMBER = {0}\nSALARY = U$ {1}", employeeNumber, salary.ToString("0.00", CultureInfo.InvariantCulture));
    }
}