namespace GitHubFiles.Exercises;

class E1080HighestPosition
{
    public static void Run()
    {
        int[] numbers = new int[100];
        int highest, position;

        for (int i = 0; i < 100; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        highest = numbers.Max();
        position = Array.IndexOf(numbers, highest) +1;

        Console.WriteLine("{0}\n{1}", highest, position);

    }
}