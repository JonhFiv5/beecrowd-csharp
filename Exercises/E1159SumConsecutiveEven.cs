namespace GitHubFiles.Exercises;

class E1159SumConsecutiveEven
{
    public static void Run()
    {
        int x, evenNumsSum, evenNumsQtt;
        
        do
        {
            evenNumsSum = 0;
            evenNumsQtt = 0;
        
            x = int.Parse(Console.ReadLine());
        
            while (true)
            {
                if (evenNumsQtt < 5 || x == 0)
                {
                    break;
                }
                if (x % 2 == 0)
                {
                    evenNumsSum += x;
                    evenNumsQtt++;
                }
                x++;
            };
        
            Console.WriteLine(evenNumsSum);
        
        } while (x != 0);

    }
}