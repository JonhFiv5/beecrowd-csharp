namespace GitHubFiles.Exercises;

class E1070SixOddNumbers
{
    public static void Run()
    {
        int number, oddCount = 0;

        number = int.Parse(Console.ReadLine());

        while (oddCount < 6)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
                oddCount++;
            }
            number++;
        }

    }
}