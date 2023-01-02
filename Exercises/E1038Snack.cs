using System.Globalization;

namespace GitHubFiles.Exercises;

class E1038Snack
{
    public static void Run()
    {
        float[] values = {4, 4.5f, 5, 2, 1.5f};
        string[] input;
        int cod, qtt;
        float totalPrice;

        input = Console.ReadLine().Split(" ");
        cod = Int32.Parse(input[0]);
        qtt = Int32.Parse(input[1]);

        totalPrice = values[cod - 1] * qtt;
        Console.WriteLine("Total: R$ {0}", totalPrice.ToString("0.00", CultureInfo.InvariantCulture));

    }
}