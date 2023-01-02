namespace GitHubFiles.Exercises;

class E1115Quadrant
{
    public static void Run()
    {
        string[] input;
        int x, y;

        while (true)
        {
            input = Console.ReadLine().Split(" ");
            x = int.Parse(input[0]);
            y = int.Parse(input[1]);

            if (x == 0 || y == 0)
            {
                break;
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("primeiro");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("segundo");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("terceiro");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("quarto");
            }
        }
    }
}