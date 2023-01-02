namespace GitHubFiles.Exercises;

class E1113AscendingDescending
{
    public static void Run()
    {
        string[] input;
        int numA, numB;

        while (true)
        {
            input = Console.ReadLine().Split(" ");
            numA = int.Parse(input[0]);
            numB = int.Parse(input[1]);

            if (numA == numB)
            {
                break;
            }
            else if (numA < numB)
            {
                Console.WriteLine("Crescente");
            }
            else
            {
                Console.WriteLine("Decrescente");
            }
        }
    }
}