namespace GitHubFiles.Exercises;

class E1179ArrayFill04
{
    public static void Run()
    {
        int[] evenNumbers = new int[5];
        int[] oddNumbers = new int[5];
        int inputNumber, currentEvenIndex = 0, currentOddIndex = 0;
        
        for (int i = 0; i < 15; i++)
        {
            inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber % 2 == 0)
            {
                evenNumbers[currentEvenIndex] = inputNumber;
                currentEvenIndex++;
                if (currentEvenIndex == 5)
                {
                    printNumbersArray(evenNumbers, "par", currentEvenIndex);
                    currentEvenIndex = 0;
                }
            }
            else
            {
                oddNumbers[currentOddIndex] = inputNumber;
                currentOddIndex++;
                if (currentOddIndex == 5)
                {
                    printNumbersArray(oddNumbers, "impar", currentOddIndex);
                    currentOddIndex = 0;
                }
            }
        }
        
        printNumbersArray(oddNumbers, "impar", currentOddIndex);
        printNumbersArray(evenNumbers, "par", currentEvenIndex);
        
        
        void printNumbersArray(int[] numbers, string name, int positions)
        {
            for (int i = 0; i < positions; i++)
            {
                Console.WriteLine($"{name}[{i}] = {numbers[i]}");
            }
        }
    }
}