namespace GitHubFiles.Exercises;

class E1061EventTime
{
    public static void Run()
    {
        string[] input;
        int startDay, startHour, startMinute, startSecond, endDay, endHour, endMinute, endSecond, totalDay, totalHour, totalMinute, totalSecond, totalSeconds;

        input = Console.ReadLine().Split(" ");
        startDay = int.Parse(input[1]);
        input = Console.ReadLine().Split(" : ");
        startHour = int.Parse(input[0]);
        startMinute = int.Parse(input[1]);
        startSecond = int.Parse(input[2]);

        input = Console.ReadLine().Split(" ");
        endDay = int.Parse(input[1]);
        input = Console.ReadLine().Split(" : ");
        endHour = int.Parse(input[0]);
        endMinute = int.Parse(input[1]);
        endSecond = int.Parse(input[2]);

        totalSeconds = endSecond - startSecond;
        totalSeconds += (endMinute - startMinute) * 60;
        totalSeconds += (endHour - startHour) * 3600;
        totalSeconds += (endDay - startDay) * 86400;

        totalDay = (int) totalSeconds / 86400;
        totalSeconds = totalSeconds % 86400;

        totalHour = (int) totalSeconds / 3600;
        totalSeconds = totalSeconds % 3600;

        totalMinute = (int) totalSeconds / 60;
        totalSeconds = totalSeconds % 60;

        totalSecond = totalSeconds;

        Console.WriteLine("{0} dia(s)\n{1} hora(s)\n{2} minuto(s)\n{3} segundo(s)", totalDay, totalHour, totalMinute, totalSecond);

    }
}