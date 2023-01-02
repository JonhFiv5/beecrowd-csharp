namespace GitHubFiles.Exercises;

class E1865Mjolnir
{
    public static void Run()
    {
        string[] input;
        int testCases = 0;
        
        testCases = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testCases; i++)
        {
            input = Console.ReadLine().Split(" ");
            if (input[0] == "Thor")
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }
        }

    }
}