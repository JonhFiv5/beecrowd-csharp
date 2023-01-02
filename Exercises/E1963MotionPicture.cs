using System.Globalization;

namespace GitHubFiles.Exercises;

class E1963MotionPicture
{
    public static void Run()
    {
        
        string[] input;
        float oldPrice, newPrice, priceIncreasePercentage;
        
        input = Console.ReadLine().Split(" ");
        
        oldPrice = float.Parse(input[0]);
        newPrice = float.Parse(input[1]);
        priceIncreasePercentage = ((newPrice - oldPrice) / oldPrice) * 100;
        
        Console.WriteLine(priceIncreasePercentage.ToString("0.00", CultureInfo.InvariantCulture) + "%");
    }
}