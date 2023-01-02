namespace GitHubFiles.Exercises;

class E1146GrowingSequences
{
    public static void Run()
    {
        int x;
        
        while (true)
        {
            x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                break;
            }
        
            for (int i = 1; i <= x; i++)
            {
                if (i != x)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}