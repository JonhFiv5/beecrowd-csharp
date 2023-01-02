namespace GitHubFiles.Exercises;

class E1075Remaining02
{
    public static void Run()
    {
        int number;

        number = int.Parse(Console.ReadLine());

        for (int i = 1; i < 100 ; i++)
        {
            if (i % number == 2)
            {
                Console.WriteLine(i);
            }
        }

    }
}