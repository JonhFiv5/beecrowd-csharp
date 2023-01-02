namespace GitHubFiles.Exercises;

class E1020AgeInDays
{
    public static void Run()
    {
        int totalDaysAge, years, months, days;
        /*
            Considering:
                * Year = 365 days
                * Month = 30 days
        */

        totalDaysAge = int.Parse(Console.ReadLine());
        years = totalDaysAge / 365;
        totalDaysAge -= years * 365;
        months = totalDaysAge / 30;
        days = totalDaysAge - months * 30;

        Console.WriteLine("{0} ano(s)", years);
        Console.WriteLine("{0} mes(es)", months);
        Console.WriteLine("{0} dia(s)", days);
    }
}