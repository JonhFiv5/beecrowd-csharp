namespace GitHubFiles.Exercises;

class E1143SquaredAndCubic
{
    public static void Run()
    {
        int lines;

        lines = int.Parse(Console.ReadLine());

        for (int i = 1; i <= lines; i++)
        {
            Console.WriteLine($"{i} {i*i} {i*i*i}");
        }
    }
}