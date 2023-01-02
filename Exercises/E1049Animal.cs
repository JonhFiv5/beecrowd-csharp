namespace GitHubFiles.Exercises;

class E1049Animal
{
    public static void Run()
    {
        string? vertebralClassification, groupClassification, dietClassification, animalFound;

        vertebralClassification = Console.ReadLine();
        groupClassification = Console.ReadLine();
        dietClassification = Console.ReadLine();

        if (vertebralClassification == "vertebrado")
        {
            if (groupClassification == "ave")
            {
                if (dietClassification == "carnivoro")
                {
                    animalFound = "aguia";
                }
                else
                {
                    animalFound = "pomba";
                }
            }
            else
            {
                // Grupo mamifero
                if (dietClassification == "onivoro")
                {
                    animalFound = "homem";
                }
                else
                {
                    animalFound = "vaca";
                }
            }
        }
        else
        {
            if (groupClassification == "inseto")
            {
                if (dietClassification == "hematofago")
                {
                    animalFound = "pulga";
                }
                else
                {
                    animalFound = "lagarta";
                }
            }
            else
            {
                // Grupo anelideo
                if (dietClassification == "hematofago")
                {
                    animalFound = "sanguessuga";
                }
                else
                {
                    animalFound = "minhoca";
                }
            }
        }

        Console.WriteLine(animalFound);

    }
}