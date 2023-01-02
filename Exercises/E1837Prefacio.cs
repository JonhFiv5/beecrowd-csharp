namespace GitHubFiles.Exercises;

class E1837Prefacio
{
    public static void Run()
    {
        string[] input;
        int a, b, quotient, rest;
        
        input = Console.ReadLine().Split();
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
        
        quotient = a / b;
        
        if (a < 0 && b > 0)
        {
            if (quotient * b > a)
            {
                quotient--;
            }
            rest = a - (b * quotient);
        }
        else if (a < 0 && b < 0)
        {
            if (quotient * b > a)
            {
                quotient++;
            }
            rest = a - (b * quotient);
        }
        else
        {
            rest = a - b * quotient;
        }
        
        Console.WriteLine(quotient + " " + rest);
    }
}