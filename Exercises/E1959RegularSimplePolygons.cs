namespace GitHubFiles.Exercises;

class E1959RegularSimplePolygons
{
    public static void Run()
    {
        string[] input;
        uint sides, sideLength, perimeter;
        
        input = Console.ReadLine().Split(" ");
        sides = uint.Parse(input[0]);
        sideLength = uint.Parse(input[1]);
        
        perimeter = sides * sideLength;
        
        Console.WriteLine(perimeter);

    }
}