namespace GitHubFiles.Exercises;

class E1172ArrayReplacement01
{
    public static void Run()
    {
        int num;
        int[] numbers = new int[10];
        
        for (int i = 0; i < 10; i++)
        {
            num = int.Parse(Console.ReadLine());
        
            if (num <= 0)
            {
                numbers[i] = 1;
            }
            else
            {
                numbers[i] = num;
            }
        
        }
        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"X[{i}] = {numbers[i]}");
        }

    }
}