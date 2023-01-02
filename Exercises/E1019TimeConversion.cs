namespace GitHubFiles.Exercises;

class E1019TimeConversion
{
    public static void Run()
    {
        int totalSeconds, hours, minutes, seconds;

        totalSeconds = int.Parse(Console.ReadLine());

        hours = totalSeconds / 3600;
        totalSeconds -= hours * 3600;
        minutes = totalSeconds / 60;
        seconds = totalSeconds - (minutes * 60);

        Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);

    }
}