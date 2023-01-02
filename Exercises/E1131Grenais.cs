namespace GitHubFiles.Exercises;

class E1131Grenais
{
    public static void Run()
    {
        int interGoals = 0, gremioGoals = 0, interVictories = 0, gremioVictories = 0, drafts = 0, totalGrenais = 0;
        string[] input;
        string? decision, mostVictories;

        while (true)
        {
            totalGrenais++;
            input = Console.ReadLine().Split(" ");
            interGoals = int.Parse(input[0]);
            gremioGoals = int.Parse(input[1]);

            if (gremioGoals > interGoals)
            {
                gremioVictories++;
            }
            else if (interGoals > gremioGoals)
            {
                interVictories++;
            }
            else
            {
                drafts++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            decision = Console.ReadLine();
            if (decision.Equals("2"))
            {
                break;
            }
        }

        if (interVictories > gremioVictories)
        {
            mostVictories = "Inter";
        }
        else if (gremioVictories > interVictories)
        {
            mostVictories = "Gremio";
        }
        else
        {
            mostVictories = null;
        }

        Console.WriteLine(
            $"{totalGrenais} grenais\n" +
            $"Inter:{interVictories}\n" +
            $"Gremio:{gremioVictories}\n" +
            $"Empates:{drafts}"
        );

        if (String.IsNullOrEmpty(mostVictories))
        {
            Console.WriteLine("Nao houve vencedor");
        }
        else
        {
            Console.WriteLine($"{mostVictories} venceu mais");
        }
    }
}