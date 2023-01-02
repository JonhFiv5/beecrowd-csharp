namespace GitHubFiles.Exercises;

class E1042SimpleSort
{
    public static void Run()
    {
        List<string> values = new List<string>();
        List<int> orderedValues = new List<int>();

        values = Console.ReadLine().Split(" ").ToList();
        orderedValues = values.ConvertAll(value => int.Parse(value));
        orderedValues.Sort();

        foreach (int item in orderedValues)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        foreach (string item in values)
        {
            Console.WriteLine(item);
        }
    }
}