namespace GitHubFiles.Exercises;

class E1930ElectricalOutlet
{
    public static void Run()
    {
        int[] input;
        int totalDevices;
        
        input = Array.ConvertAll(Console.ReadLine().Split(" "), i => int.Parse(i));
        totalDevices = input.Sum() - 3;
        
        Console.WriteLine(totalDevices);

    }
}