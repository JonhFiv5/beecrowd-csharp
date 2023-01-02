namespace GitHubFiles.Exercises;

class E1132MultiplesOf13
{
    public static void Run()
    {
        int numA, numB, aux, sum = 0;
        
        numA = int.Parse(Console.ReadLine());
        numB = int.Parse(Console.ReadLine());

        if (numA > numB)
        {
            aux = numA;
            numA = numB;
            numB = aux;
        }

        for (int i = numA; i <= numB; i++)
        {
            if (i % 13 != 0)
            {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}