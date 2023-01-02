namespace GitHubFiles.Exercises;

class E1072Interval02
{
    public static void Run()
    {
        int totalNumbers, inputnumber, numbersOutInterval, numbersInInterval = 0;

        totalNumbers = int.Parse(Console.ReadLine());

        for (int i = 0; i < totalNumbers; i++)
        {
            inputnumber = int.Parse(Console.ReadLine());
            if (inputnumber >= 10 && inputnumber <= 20)
            {
                numbersInInterval++;
            }
        }

        numbersOutInterval = totalNumbers - numbersInInterval;

        Console.WriteLine("{0} in\n{1} out", numbersInInterval, numbersOutInterval);

    }
}