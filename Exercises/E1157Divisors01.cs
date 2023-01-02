namespace GitHubFiles.Exercises;

class E1157Divisors01
{
    public static void Run()
    {
        int n;
        
        n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}