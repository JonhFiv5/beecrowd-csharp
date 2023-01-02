using System.Globalization;

namespace GitHubFiles.Exercises;

class E1094Expretiments
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        int totalExperiments, experimentAnimals, totalAnimals = 0, totalFrogs = 0, totalRabbits = 0, totalRats = 0;
        string[] input;
        char animalType;

        totalExperiments = int.Parse(Console.ReadLine());

        for (int i = 0; i < totalExperiments; i++)
        {
            input = Console.ReadLine().Split(" ");
            experimentAnimals = int.Parse(input[0]);
            animalType = char.Parse(input[1]);

            totalAnimals += experimentAnimals;

            if (animalType == 'C')
            {
                totalRabbits += experimentAnimals;
            }
            else if (animalType == 'S')
            {
                totalFrogs += experimentAnimals;
            }
            else if (animalType == 'R')
            {
                totalRats += experimentAnimals;
            }
        }

        Console.WriteLine(
            $"Total: {totalAnimals} cobaias\n" +
            $"Total de coelhos: {totalRabbits}\n" +
            $"Total de ratos: {totalRats}\n" +
            $"Total de sapos: {totalFrogs}\n" +
            $"Percentual de coelhos: {((totalRabbits / (double) totalAnimals) * 100).ToString("0.00")} %\n" +
            $"Percentual de ratos: {((totalRats / (double) totalAnimals) * 100).ToString("0.00")} %\n" +
            $"Percentual de sapos: {((totalFrogs / (double) totalAnimals) * 100).ToString("0.00")} %\n"
        );
    }
}