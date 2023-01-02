namespace GitHubFiles.Exercises;

class E1564BrazilWorldCup
{
    public static void Run()
    {
        string complaints;
        
        while (true)
        {
            complaints = Console.ReadLine();
        
            if (complaints == String.Empty)
            {
                break;
            }
        
            if (complaints == "0")
            {
                Console.WriteLine("vai ter copa!");
            }
            else
            {
                Console.WriteLine("vai ter duas!");
            }
        }
    }
}