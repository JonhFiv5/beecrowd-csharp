namespace GitHubFiles.Exercises;

class E1144LogicalSequence
{
    public static void Run()
    {
        int lines;

        lines = int.Parse(Console.ReadLine());

        for (int i = 1; i <= lines; i++)
        {
            Console.WriteLine($"{i} {i*i} {i*i*i}");
            Console.WriteLine($"{i} {i*i+1} {i*i*i+1}");
        }
    }
}