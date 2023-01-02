namespace GitHubFiles.Exercises;

class E1078MultiplicationTable
{
    public static void Run()
    {
        int num;

        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", i, num, i * num);
        }

    }
}