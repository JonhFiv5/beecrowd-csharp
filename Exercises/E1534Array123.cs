namespace GitHubFiles.Exercises;

class E1534Array123
{
    public static void Run()
    {
        int[,] matrix;
        int matrixDimensions;
        
        while (true)
        {
            try
            {
                matrixDimensions = int.Parse(Console.ReadLine());
                matrix = new int[matrixDimensions, matrixDimensions];
            }
            catch (Exception)
            {
                break;
            }
        
            // Filling the matrix
            for (int i = 0; i < matrixDimensions; i++)
            {
                for (int j = 0; j < matrixDimensions; j++)
                {
                    if (j == matrixDimensions - 1 - i)
                    {
                        matrix[i, j] = 2;
                    }
                    else if (i == j)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 3;
                    }
                }
            }
        
            // Printing the matrix
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
                        Console.Write(matrix[i, j]);
                    }
                }
            }
        
        }
    }
}