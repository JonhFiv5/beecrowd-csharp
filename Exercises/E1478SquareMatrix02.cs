namespace GitHubFiles.Exercises;

class E1478SquareMatrix02
{
    public static void Run()
    {
        int[,] matrix;
        int matrixDimensions, fillValue = 0, fillIncrement = 1;
        
        while (true)
        {
            matrixDimensions = int.Parse(Console.ReadLine());
        
            if (matrixDimensions == 0)
            {
                break;
            }
        
            matrix = new int[matrixDimensions, matrixDimensions];
        
            for (int i = 0; i < matrixDimensions; i++)
            {
                fillValue = i + 1;
                for (int j = 0; j < matrixDimensions; j++)
                {
                    if (j == matrixDimensions - 1)
                    {
                        Console.WriteLine(fillValue);
                    }
                    else
                    {
                        Console.Write(fillValue + "\t");
                    }
        
                    
        
                    if (fillValue == 1)
                    {
                        fillIncrement = 1;
                    }
                    fillValue += fillIncrement;
                }
                fillIncrement = -1;
            }
        }
    }
}