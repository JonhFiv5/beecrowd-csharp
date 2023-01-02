using System.Globalization;

namespace GitHubFiles.Exercises;

class E1010SimpleCalculate
{
    public static void Run()
    {
        string product_1, product_2;
        string[] info_1, info_2;
        double totalValue;

        product_1 = Console.ReadLine();
        product_2 = Console.ReadLine();

        info_1 = product_1.Split(" ");
        info_2 = product_2.Split(" ");

        totalValue = int.Parse(info_1[1]) * double.Parse(info_1[2], CultureInfo.InvariantCulture) + int.Parse(info_2[1]) * double.Parse(info_2[2], CultureInfo.InvariantCulture);

        Console.WriteLine("VALOR A PAGAR: R$ {0}", totalValue.ToString("0.00", CultureInfo.InvariantCulture));
    }
}