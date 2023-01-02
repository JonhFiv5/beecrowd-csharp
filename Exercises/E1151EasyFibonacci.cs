namespace GitHubFiles.Exercises;

class E1151EasyFibonacci
{
    public static void Run()
    {
        int num, oldPreviousNum = 1, previousNum = 0, currentNum = 0;
        
        num = int.Parse(Console.ReadLine());
        
        // 0 1 1 2 3 5 8 13 21
        for (int i = 1; i <= num; i++)
        {
            if (i != num)
            {
                Console.Write($"{currentNum} ");
        
                currentNum = oldPreviousNum + previousNum;
                oldPreviousNum = previousNum;
                previousNum = currentNum;
            }
            else
            {
                Console.Write(currentNum);        
            }
        }

    }
}