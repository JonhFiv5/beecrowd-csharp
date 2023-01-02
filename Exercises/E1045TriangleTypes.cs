namespace GitHubFiles.Exercises;

class E1045TriangleTypes
{
    public static void Run()
    {
        List<string> rawInput = new List<string>();
        List<double> numbers = new List<double>();
        double numA, numB, numC;

        rawInput = Console.ReadLine().Split(" ").ToList();
        numbers = rawInput.ConvertAll(value => double.Parse(value));
        numbers.Sort();
        numA = numbers[2];
        numB = numbers[1];
        numC = numbers[0];

        if (numA >= numB + numC)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            
            if (numA * numA == numB * numB + numC * numC)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }

            if (numA * numA > numB * numB + numC * numC)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }

            if (numA * numA < numB * numB + numC * numC)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (numA == numB && numB == numC)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            
            if ((numA == numB && numB != numC) || (numA == numC && numC != numB) || (numB == numC && numC != numA))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }

    }
}