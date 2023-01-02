namespace GitHubFiles.Exercises;

class E1066EvenOddPositiveNegative
{
    public static void Run()
    {
        int inputNumber, evenCount = 0, oddCount = 0, positiveCount = 0, negativeCount = 0;

        for (int i = 0; i < 5; i++)
        {
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber % 2 == 0){
                evenCount++;
            }
            else
            {
                oddCount++;
            }

            if (inputNumber > 0)
            {
                positiveCount++;
            }
            else if (inputNumber < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine(
            "{0} valor(es) par(es)\n" +
            "{1} valor(es) impar(es)\n" +
            "{2} valor(es) positivo(s)\n" +
            "{3} valor(es) negativo(s)",
            evenCount, oddCount, positiveCount, negativeCount
        );

    }
}