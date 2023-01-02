namespace GitHubFiles.Exercises;

class E1096SequenceIJ02
{
    public static void Run()
    {
        int j;

        for (int i = 1; i <= 9; i++)
        {
            for (j = 7; j >= 5; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}