namespace GitHubFiles.Exercises;

class E1435SquareMatrix01
{
    public static void Run()
    {
        int matrixDimensions, matrixCenter, fillValue = 0;
        int[,] matrix;
        int totalIteracoes = 0;
        
        while (true)
        {
            matrixDimensions = int.Parse(Console.ReadLine());
        
            if (matrixDimensions == 0)
            {
                break;
            }
        
            matrix = new int[matrixDimensions, matrixDimensions];
            matrixCenter = (matrixDimensions % 2 == 0) ? (matrixDimensions / 2) : (int) (matrixDimensions / 2) + 1;
        
            int lastPosition = matrixDimensions - 1;
            fillValue = 0;
            totalIteracoes = 0;
        
            // Construindo a matriz
            for (int k = 0; k < matrixCenter; k++)
            {
                fillValue++;
                for (int i = k; i < matrixDimensions - k; i++)
                {
                    for (int j = k; j < matrixDimensions - k; j++)
                    {
                        matrix[i, j] = fillValue;
                        totalIteracoes++;
                    }
                }
            }
        
            // Exibindo a matriz
            for (int i = 0; i < matrixDimensions; i++)
        
            {
                for (int j = 0; j < matrixDimensions; j++)
                {
                    if (j == matrixDimensions - 1)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                }
            }
        
            Console.WriteLine("Iteracoes: " + totalIteracoes);
        }

    }
}