namespace GitHubFiles.Exercises;

class E1095SequenceIJ01
{
    public static void Run()
    {
        int i = 1;
        int j = 60;

        while (j >= 0)
        {
            Console.WriteLine($"I={i} j={j}");
            i += 3;
            j -= 5;
        }

    }
}