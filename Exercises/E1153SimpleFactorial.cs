namespace GitHubFiles.Exercises;

class E1153SimpleFactorial
{
    public static void Run()
    {
        int num, factorial = 1;
        
        num = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        
        Console.WriteLine(factorial);

    }
}