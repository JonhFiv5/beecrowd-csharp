namespace GitHubFiles.Exercises;

class E1914WhoseTurnIsIt
{
    public static void Run()
    {
        int testCases;
        string[] input;
        int[] inputNumbers;
        string playerEven, playerOdd;
        int result;
        
        testCases = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testCases; i++)
        {
            input = Console.ReadLine().Split(" ");
            inputNumbers = Array.ConvertAll(Console.ReadLine().Split(" "), i => int.Parse(i));
        
            result = inputNumbers[0] + inputNumbers[1];
        
            playerEven = input[0];
            playerOdd = input[2];
            if (input[1] == "IMPAR")
            {
                (playerEven, playerOdd) = (playerOdd, playerEven);
            }
        
            if (result % 2 == 0)
            {
                Console.WriteLine(playerEven);
            }
            else
            {
                Console.WriteLine(playerOdd);
            }
        
        }
    }
}