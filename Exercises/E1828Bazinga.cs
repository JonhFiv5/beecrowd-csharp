namespace GitHubFiles.Exercises;

class E1828Bazinga
{
    public static void Run()
    {
        int totalTests, result;
        string[] input;
        string sheldonChoice, rajChoice;
        IDictionary<int, string> resultDict = new Dictionary<int, string>(){
            {1, "Bazinga!"},
            {2, "Raj trapaceou!"},
            {3, "De novo!"},
        };
        
        totalTests = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < totalTests; i++)
        {
            input = Console.ReadLine().Split(" ");
            sheldonChoice = input[0];
            rajChoice = input[1];
        
            if (sheldonChoice == rajChoice)
            {
                result = 3;
            }
            else
            {
                result = 2;
        
                if (sheldonChoice == "pedra")
                {
                    if (rajChoice == "tesoura" || rajChoice == "lagarto")
                    {
                        result = 1;
                    }
                }
                else if (sheldonChoice == "papel")
                {
                    if (rajChoice == "pedra" || rajChoice == "Spock")
                    {
                        result = 1;
                    }
                }
                else if (sheldonChoice == "tesoura")
                {
                    if (rajChoice == "papel" || rajChoice == "lagarto")
                    {
                        result = 1;
                    }
                }
                else if (sheldonChoice == "lagarto")
                {
                    if (rajChoice == "Spock" || rajChoice == "papel")
                    {
                        result = 1;
                    }
                }
                else if (sheldonChoice == "Spock")
                {
                    if (rajChoice == "tesoura" || rajChoice == "pedra")
                    {
                        result = 1;
                    }
                }
            }
            Console.WriteLine($"Caso #{result}: {resultDict[result]}");
        }

    }
}