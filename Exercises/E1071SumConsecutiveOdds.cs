namespace GitHubFiles.Exercises;

class E1071SumConsecutiveOdds
{
    public static void Run()
    {
        int numA, numB, numTemp, oddNumbersSum = 0;

        numA = int.Parse(Console.ReadLine());
        numB = int.Parse(Console.ReadLine());

        if (numA > numB)
        {
            numTemp = numA;
            numA = numB;
            numB = numTemp;
        }

        for (int i = ++numA; i < numB; i++)
        {
            if ((i % 2) != 0)
            {
                oddNumbersSum += i;
            }
        }

        Console.WriteLine(oddNumbersSum);

    }
}