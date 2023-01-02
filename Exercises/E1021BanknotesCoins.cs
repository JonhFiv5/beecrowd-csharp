using System.Globalization;

namespace GitHubFiles.Exercises;

class E1021BanknotesCoins
{
    public static void Run()
    {
        int[] possibleNotes = {100, 50, 20, 10, 5, 2};
        // Here coin values have been multiplied by 100 and converted to integer form
        int[] possibleCoins = {100, 50, 25, 10, 5, 1};
        int currentAmount;
        List<int> necessaryNotes = new List<int>();
        List<int> necessaryCoins = new List<int>();
        double totalMoney;
        int notes, coins;


        totalMoney = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        notes = (int) totalMoney;
        coins = (int) ((totalMoney - notes) * 100);

        // calculating notes
        foreach(int note in possibleNotes)
        {
            currentAmount = (int) ((notes - notes % note) / note);
            necessaryNotes.Add(currentAmount);
            notes -= currentAmount * note;
        }

        coins += notes * 100;

        // calculating coins
        foreach(int coin in possibleCoins)
        {
            currentAmount = (int) ((coins - coins % coin) / coin);
            necessaryCoins.Add(currentAmount);
            coins -= currentAmount * coin;
        }

        // output
        Console.WriteLine("NOTAS:");
        for(int i = 0; i < necessaryNotes.Count(); i++)
        {
            Console.WriteLine("{0} nota(s) de R$ {1}.00", necessaryNotes[i], possibleNotes[i]);
        }

        Console.WriteLine("MOEDAS:");
        for(int i = 0; i < necessaryCoins.Count(); i++)
        {
            double outputCoin = (double) (possibleCoins[i]/100.0);
            Console.WriteLine("{0} moeda(s) de R$ {1}", necessaryCoins[i], outputCoin.ToString("0.00", CultureInfo.InvariantCulture));
        }

    }
}