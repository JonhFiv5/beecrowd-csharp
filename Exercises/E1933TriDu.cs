namespace GitHubFiles.Exercises;

class E1933TriDu
{
    public static void Run()
    {
        string[] input;
        int cardA, cardB;
        
        input = Console.ReadLine().Split(" ");
        cardA = int.Parse(input[0]);
        cardB = int.Parse(input[1]);
        
        if (cardA == cardB)
        {
            Console.WriteLine(cardA);
        }
        else
        {
            Console.WriteLine(cardA > cardB ? cardA : cardB);
        }
    }
}