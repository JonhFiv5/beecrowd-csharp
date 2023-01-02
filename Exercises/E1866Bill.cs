namespace GitHubFiles.Exercises;

class E1866Bill
{
    public static void Run()
    {
        int testCases, input;
        
        testCases = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testCases; i++)
        {
            input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}