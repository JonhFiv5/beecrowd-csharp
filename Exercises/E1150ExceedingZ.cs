namespace GitHubFiles.Exercises;

class E1150ExceedingZ
{
    public static void Run()
    {
        int x, z, numbersAmount = 0, sum = 0;
        
        x = int.Parse(Console.ReadLine());
        
        do
        {
            z = int.Parse(Console.ReadLine());
        } while (z <= x);
        
        do
        {
            sum += x;
            x++;
            numbersAmount++;
        } while (sum < z);
        
        Console.WriteLine(numbersAmount);

    }
}