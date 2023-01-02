namespace GitHubFiles.Exercises;

class E1173ArrayFill01
{
    public static void Run()
    {
        int num;
        int[] numbers = new int[10];
        
        num = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = num;
            Console.WriteLine($"N[{i}] = {num}");
            num *= 2;
        }

    }
}