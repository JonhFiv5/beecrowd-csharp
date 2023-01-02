namespace GitHubFiles.Exercises;

class E1176FibonacciArray
{
    public static void Run()
    {
        int testCases, selectedPosition, olderNumber, oldNumber, currentNumber;
        
        
        
        testCases = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testCases; i++)
        {
            selectedPosition = int.Parse(Console.ReadLine());
        
            olderNumber = 0;
            oldNumber = 1;
            currentNumber = 0;
        
            for (int j = 0; j < selectedPosition; j++)
            {
                olderNumber = oldNumber;
                oldNumber = currentNumber;
                currentNumber = olderNumber + oldNumber;
            }
        
            Console.WriteLine($"Fib({selectedPosition}) = {currentNumber}");
        }

    }
}