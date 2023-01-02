namespace GitHubFiles.Exercises;

class E1858ARaposaDeTheon
{
    public static void Run()
    {
        List<int> input;
        int result;
        
        Console.ReadLine();
        input = Console.ReadLine().Split(" ").ToList().ConvertAll(value => int.Parse(value));
        result = input.IndexOf(input.Min()) + 1;
        
        Console.WriteLine(result);

    }
}