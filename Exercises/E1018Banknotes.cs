namespace GitHubFiles.Exercises;

class E1018Banknotes
{
    public static void Run()
    {
        int[] POSSIBLE_BANKNOTES = {100, 50, 20, 10, 5, 2, 1};

        List<int> necessaryBanknotes = new List<int>();
        int withdrawAmount, currentNoteAmount;


        withdrawAmount = int.Parse(Console.ReadLine());
        Console.WriteLine(withdrawAmount);

        foreach(int banknoteValue in POSSIBLE_BANKNOTES)
        {
            currentNoteAmount = (withdrawAmount - (withdrawAmount % banknoteValue)) / banknoteValue;
            necessaryBanknotes.Add(currentNoteAmount);
            withdrawAmount -= currentNoteAmount * banknoteValue;
        }

        for(int i = 0; i < necessaryBanknotes.Count(); i++) {
            Console.WriteLine("{0} nota(s) de R$ {1},00", necessaryBanknotes[i], POSSIBLE_BANKNOTES[i]);
        }
    }
}