namespace GitHubFiles.Exercises;

class E1589BobConduit
{
    public static void Run()
    {
        int testCases, radius01, radius02, conduitRadius;
        string[] input;
        
        testCases = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testCases; i++)
        {
            input = Console.ReadLine().Split();
            radius01 = int.Parse(input[0]);
            radius02 = int.Parse(input[1]);
        
            conduitRadius = radius01 + radius02;
            Console.WriteLine(conduitRadius);
        }
    }
}