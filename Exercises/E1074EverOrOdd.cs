namespace GitHubFiles.Exercises;

class E1074EverOrOdd
{
    public static void Run()
    {
        int totalNumbers, inputNumber;
        string outputMessage = "";

        totalNumbers = int.Parse(Console.ReadLine());

        for (int i = 0; i < totalNumbers; i++)
        {
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber == 0){
                outputMessage = "NULL";
            }
            else
            {
                if (inputNumber % 2 == 0)
                {
                    outputMessage = "EVEN";
                }
                else
                {
                    outputMessage = "ODD";
                }

                if (inputNumber > 0)
                {
                    outputMessage += " POSITIVE";
                }
                else
                {
                    outputMessage += " NEGATIVE";
                }
            }

            Console.WriteLine(outputMessage);
        }

    }
}