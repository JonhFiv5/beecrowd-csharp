namespace GitHubFiles.Exercises;

class E1047GameTimeWithMinutes
{
    public static void Run()
    {
        string[] input;
        int startHour, startMinute, endHour, endMinute, durationHours = 0, durationMinutes = 0;

        input = Console.ReadLine().Split(" ");
        startHour = int.Parse(input[0]);
        startMinute = int.Parse(input[1]);
        endHour = int.Parse(input[2]);
        endMinute = int.Parse(input[3]);

        if (startHour == endHour)
        {
            if (startMinute == endMinute)
            {
                durationHours = 24;
                durationMinutes = 0;
            }
            else if (startMinute < endMinute)
            {
                durationHours = 0;
                durationMinutes = endMinute - startMinute;
            }
            else if (startMinute > endMinute)
            {
                durationHours = 23;
                durationMinutes = 60 - (startMinute - endMinute);
            }
        }
        else if (startHour < endHour)
        {
            if (startMinute == endMinute)
            {
                durationHours = endHour - startHour;
                durationMinutes = 0;
            }
            else if (startMinute < endMinute)
            {
                durationHours = endHour - startHour;
                durationMinutes = endMinute - startMinute;
            }
            else if (startMinute > endMinute)
            {
                durationHours = (endHour - startHour) - 1;
                durationMinutes = 60 - (startMinute - endMinute);
            }
        }
        else if (startHour > endHour)
        {
            if (startMinute == endMinute)
            {
                durationHours = (24 - startHour) + endHour;
                durationMinutes = 0;
            }
            else if (startMinute < endMinute)
            {
                durationHours = (24 - startHour) + endHour;
                durationMinutes = endMinute - startMinute;
            }
            else if (startMinute > endMinute)
            {
                durationHours = (24 - startHour) + endHour - 1;
                durationMinutes = 60 - (startMinute - endMinute);
            }
        }

        Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", durationHours, durationMinutes);

    }
}