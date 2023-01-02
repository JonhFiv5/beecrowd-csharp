namespace GitHubFiles.Exercises;

class E1180LowestNumberPosition
{
    public static void Run()
    {
        int[] numbers;
        int arraySize, lowestNumberValue, lowestNumberPosition;
        
        arraySize = int.Parse(Console.ReadLine());
        numbers = new int[arraySize];
        
        numbers = Array.ConvertAll(Console.ReadLine().Split(" ").ToArray(), item => int.Parse(item));
        
        lowestNumberValue = numbers.Min();
        lowestNumberPosition = Array.IndexOf(numbers, lowestNumberValue);
        
        Console.WriteLine("Menor valor: " + lowestNumberValue);
        Console.WriteLine("Posicao: " + lowestNumberPosition);

    }
}