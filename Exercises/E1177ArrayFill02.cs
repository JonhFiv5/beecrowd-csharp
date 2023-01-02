namespace GitHubFiles.Exercises;

class E1177ArrayFill02
{
    public static void Run()
    {
        int[] numbers = new int[1000];
        int sequenceLimit, currentSequenceNumber = 0;
        
        sequenceLimit = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < 1000; i++)
        {
            numbers[i] = currentSequenceNumber++;
            if (currentSequenceNumber == sequenceLimit)
            {
                currentSequenceNumber = 0;
            }
        }
        
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine($"N[{i}] = {numbers[i]}");
        }

    }
}