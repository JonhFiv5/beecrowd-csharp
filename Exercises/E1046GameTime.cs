namespace GitHubFiles.Exercises;

class E1046GameTime
{
    public static void Run()
    {
        string[] input;
        int startTime, endTime, totalDuration;

        input = Console.ReadLine().Split(" ");
        startTime = int.Parse(input[0]);
        endTime = int.Parse(input[1]);

        if (startTime == endTime)
        {
            totalDuration = 24;
        }
        else if(endTime > startTime)
        {
            totalDuration = endTime - startTime;
        }
        else
        {
            totalDuration = (24 - startTime) + endTime;
        }

        Console.WriteLine($"O JOGO DUROU {totalDuration} HORA(S)");

    }
}