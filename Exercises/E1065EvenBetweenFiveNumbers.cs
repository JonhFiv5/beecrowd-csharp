namespace GitHubFiles.Exercises;

class E1065EvenBetweenFiveNumbers
{
    public static void Run()
    {
        int number, evenCount = 0;

        for (int i = 0; i < 5; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine("{0} valores pares", evenCount);

    }
}