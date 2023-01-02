namespace GitHubFiles.Exercises;

class E1557SquareMatrix03
{
    public static void Run()
    {
        int matrixDimension;
        
        while (true)
        {
            matrixDimension = int.Parse(Console.ReadLine());
            if (matrixDimension == 0)
            {
                break;
            }
        
            for (int i = 0; i < matrixDimension; i++)
            {
                for (int j = 0; j < matrixDimension; j++)
                {
                    Console.Write(Math.Pow(2, i + j) + " ");
                }
                Console.Write("\n");
            }
        }
    }
}