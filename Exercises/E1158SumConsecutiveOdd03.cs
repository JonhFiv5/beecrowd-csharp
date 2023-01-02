namespace GitHubFiles.Exercises;

class E1158SumConsecutiveOdd03
{
    public static void Run()
    {
        string[] input;
        int testCases, x, y, oddNumsSum, oddNumsQtt;
        
        testCases = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testCases; i++)
        {
            oddNumsSum = 0;
            oddNumsQtt = 0;
        
            input = Console.ReadLine().Split(" ");
            x = int.Parse(input[0]);
            y = int.Parse(input[1]);
        
            do
            {
                if (x % 2 != 0)
                {
                    oddNumsSum += x;
                    oddNumsQtt++;
                }
                x++;
            } while (oddNumsQtt < y);
        
            Console.WriteLine(oddNumsSum);
        
        }

    }
}