namespace GitHubFiles.Exercises;

class E1142PUM
{
    public static void Run()
    {
        int lines;

        lines = int.Parse(Console.ReadLine());

        for (int i = 1; i <= lines * 4; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine("PUM");
            }
            else
            {
                Console.Write($"{i} ");
            }
        }
    }
}