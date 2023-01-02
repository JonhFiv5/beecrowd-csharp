namespace GitHubFiles.Exercises;

class E1759HoHoHo
{
    public static void Run()
    {
        int totalHos;
        
        totalHos = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < totalHos; i++)
        {
            if (i == totalHos - 1) {
                Console.WriteLine("Ho!");
            }
            else
            {
                Console.Write("Ho ");
            }
        }
    }
}