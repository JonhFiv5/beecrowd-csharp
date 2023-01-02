namespace GitHubFiles.Exercises;

class E1059EvenNumbers
{
    public static void Run()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}