namespace GitHubFiles.Exercises;

class E1067OddNumbers
{
    public static void Run()
    {
        int inputNumber;

        inputNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= inputNumber; i += 2)
            Console.WriteLine(i);

    }
}