namespace GitHubFiles.Exercises;

class E1164PerfectNumber
{
    public static void Run()
    {
        int totalTests, number, sum;
        
        totalTests = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < totalTests; i++)
        {
            sum = 0;
            number = int.Parse(Console.ReadLine());
        
            for (int j = 1; j < number; j++)
            {
                if (number % j == 0)
                {
                    sum += j;
                }
            }
        
            if (sum == number)
            {
                Console.WriteLine(number + " eh perfeito");
            }
            else
            {
                Console.WriteLine(number + " nao eh perfeito");
            }
        }
    }
}