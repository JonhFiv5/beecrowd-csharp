using System.Globalization;

namespace GitHubFiles.Exercises;

class E1051Taxes
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        double salary, taxedSalaray, taxValue = 0;

        salary = double.Parse(Console.ReadLine());

        if (salary <= 2000)
        {
            Console.WriteLine("Isento");
        }
        else if (salary > 2000 && salary <= 3000)
        {
            taxedSalaray = salary - 2000;
            taxValue = taxedSalaray * 1.08 - taxedSalaray;
        }
        else if (salary > 3000 && salary <= 4500)
        {
            // applying 8% tax over R$ 1000.00
            taxValue = 80;
            // applying 18% tax for the money exceding R$ 3000.00
            taxedSalaray = salary - 3000;
            taxValue += taxedSalaray * 1.18 - taxedSalaray;
        }
        else if (salary > 4500)
        {
            // applying 8% tax over R$ 1000.00 and 18% over R$ 1500.00
            taxValue = 350;
            // applying 28% tax for the money exceding R$ 4500.00
            taxedSalaray = salary - 4500;
            taxValue += taxedSalaray * 1.28 - taxedSalaray;    
        }

        if (taxValue > 0)
        {
            Console.WriteLine("R$ " + taxValue.ToString("0.00"));
        }
    }
}