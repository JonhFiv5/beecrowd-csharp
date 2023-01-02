namespace GitHubFiles.Exercises;

class E1145LogicalSequence02
{
    public static void Run()
    {
        string[] input;
        int x, y;
        
        input = Console.ReadLine().Split(" ");
        x = int.Parse(input[0]);
        y = int.Parse(input[1]);
        
        for (int i = 1; i <= y; i++)
        {
            if (i % x == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.Write($"{i} ");
            }
        }

    }
}