namespace GitHubFiles.Exercises;

class E1789TheRaceOfSlugs
{
    public static void Run()
    {
        List<int> slugSpeeds = new List<int>();
        int topSpeed;
        string totalSlugs;
        
        while (true)
        {
            totalSlugs = Console.ReadLine();
            if (totalSlugs == String.Empty)
            {
                break;
            }
        
            slugSpeeds = Console.ReadLine().Split().ToList().ConvertAll(value => int.Parse(value));
            topSpeed = slugSpeeds.Max();
        
            if (topSpeed < 10)
            {
                Console.WriteLine(1);
            }
            else if (topSpeed >= 10 && topSpeed < 20)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(3);
            }
        }

    }
}