namespace GitHubFiles.Exercises;

class E1044Multiples
{
    public static void Run()
    {
        List<string> rawInput = new List<string>();
        List<int> inputNumbers = new List<int>();
        int numA, numB;

        rawInput = Console.ReadLine().Split(" ").ToList();
        inputNumbers = rawInput.ConvertAll(value => int.Parse(value));
        inputNumbers.Sort();
        numA = inputNumbers[0];
        numB = inputNumbers[1];

        if (numB % numA == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}