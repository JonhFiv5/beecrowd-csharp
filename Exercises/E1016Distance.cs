namespace GitHubFiles.Exercises;

class E1016Distance
{
    public static void Run()
    {
        int distance, time;

        distance = int.Parse(Console.ReadLine());
        time = distance * 2;

        Console.WriteLine("{0} minutos", time);
    }
}