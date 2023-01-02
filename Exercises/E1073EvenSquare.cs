namespace GitHubFiles.Exercises;

class E1073EvenSquare
{
    public static void Run()
    {
        int inputNumber;

        inputNumber = int.Parse(Console.ReadLine());

        for (int i = 2; i <= inputNumber; i += 2)
        {
            Console.WriteLine("{0}^2 = {1}", i, i*i);
        }

    }
}