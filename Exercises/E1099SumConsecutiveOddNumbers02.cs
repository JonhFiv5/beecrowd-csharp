namespace GitHubFiles.Exercises;

class E1099SumConsecutiveOddNumbers02
{
    public static void Run()
    {
        int testsNumber, valueA, valueB, aux, oddNumbersSum;
        string[] input;

        testsNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < testsNumber; i++)
        {
            input = Console.ReadLine().Split(" ");
            valueA = int.Parse(input[0]);
            valueB = int.Parse(input[1]);

            if (valueA > valueB)
            {
                aux = valueA;
                valueA = valueB;
                valueB = aux;
            }

            valueA = (valueA % 2 != 0) ? valueA + 2 : valueA + 1;
            oddNumbersSum = 0;

            for(int j = valueA; j < valueB; j+=2){
                oddNumbersSum += j;
            }
            
            Console.WriteLine(oddNumbersSum);
        }

    }
}