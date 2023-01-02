namespace GitHubFiles.Exercises;

class E1101SequenceNumbersSum
{
    public static void Run()
    {
        string[] input;
        int numA, numB, aux, sum;

        while (true)
        {
            input = Console.ReadLine().Split(" ");
            numA = int.Parse(input[0]);
            numB = int.Parse(input[1]);

            if (numA <= 0 || numB <= 0)
            {
                break;
            }

            if (numA > numB)
            {
                aux = numA;
                numA = numB;
                numB = aux;
            }

            sum = 0;
            for (int i = numA; i <= numB; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }

            Console.WriteLine($"Sum={sum}");
        };
    }
}