namespace GitHubFiles.Exercises;

class E1827SquareArray04
{
    public static void Run()
    {
        string input;
        int matrixDimensions, matrixPosition, centerPosition, innerStart;
        
        while (true)
        {
            input = Console.ReadLine();
            if (input == String.Empty)
            {
                break;
            }
        
            matrixDimensions = int.Parse(input);
            centerPosition = matrixDimensions / 2;
            innerStart = matrixDimensions / 3;
        
            // Printing the matrix
            for (int i = 0; i < matrixDimensions; i++)
            {
                for (int j = 0; j < matrixDimensions; j++)
                {
                    // Printing the outer part
                    matrixPosition = 0;
        
                    // Printing the main diagonal
                    if (i == j)
                    {
                        matrixPosition = 2;
                    }
                    // Printing the secondary diagonal
                    else if (j == matrixDimensions - 1 - i)
                    {
                        matrixPosition = 3;
                    }
        
                    // Printing inner part
                    if (i >= innerStart && j >= innerStart)
                    {
                        if (i < matrixDimensions - innerStart && j < matrixDimensions - innerStart)
                        {
                            matrixPosition = 1;
                        }
                    }
        
                    // Printing the center
                    if (i == centerPosition && j == centerPosition)
                    {
                        matrixPosition = 4;
                    }
        
                    Console.Write(matrixPosition);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

    }
}