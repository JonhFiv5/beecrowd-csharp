namespace GitHubFiles.Exercises;

class E1149SummingConsecutiveIntegers
{
    public static void Run()
    {
        List<string> input = new List<string>();
        List<int> numbers = new List<int>();
        int start, qtt, sum = 0;
        
        input = Console.ReadLine().Split(" ").ToList();
        
        numbers = input.ConvertAll(i => int.Parse(i));
        numbers.RemoveAll(i => i <= 0);
        
        start = numbers[0];
        qtt = numbers[1];
        
        for (int i = start; i < start + qtt; i++)
        {
            sum += i;
        }
        
        Console.WriteLine(sum);

    }
}