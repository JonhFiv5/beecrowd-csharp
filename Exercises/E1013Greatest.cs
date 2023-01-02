namespace GitHubFiles.Exercises;

class E1013Greatest
{
    public static void Run()
    {
        string[] input;
        int a, b, c;
        double greatest;

        input = Console.ReadLine().Split(" ");

        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
        c = int.Parse(input[2]);

        greatest = (a + b + Math.Abs(a - b)) / 2;
        greatest = (c + greatest + Math.Abs(c - greatest)) / 2;

        Console.WriteLine("{0} eh o maior", greatest);
    }
}