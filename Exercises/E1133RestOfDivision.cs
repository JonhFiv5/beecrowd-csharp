namespace GitHubFiles.Exercises;

class E1133RestOfDivision
{
    public static void Run()
    {
        int numA, numB, aux;

        numA = int.Parse(Console.ReadLine());
        numB = int.Parse(Console.ReadLine());

        if (numA > numB)
        {
            aux = numA;
            numA = numB;
            numB = aux;
        }

        for (int i = numA+1; i < numB; i++)
        {
            if ((i % 5 == 2) || (i % 5 == 3))
            {
                Console.WriteLine(i);
            }
        }
    }
}