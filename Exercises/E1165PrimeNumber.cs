namespace GitHubFiles.Exercises;

class E1165PrimeNumber
{
    public static void Run()
    {
        int totalTests, number;
        bool extraDivisors;
        
        totalTests = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < totalTests; i++)
        {
            number = int.Parse(Console.ReadLine());
        
            extraDivisors = false;
            for (int j = 2; j < number; j++)
            {
                if (number % j == 0)
                {
                    extraDivisors = true;
                    break;
                }
            }
        
            if (extraDivisors || number == 1)
            {
                Console.WriteLine(number + " nao eh primo");
            }
            else
            {
                Console.WriteLine(number + " eh primo");
            }
        }
    }
}