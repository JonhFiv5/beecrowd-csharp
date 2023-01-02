using System.Globalization;

namespace GitHubFiles.Exercises;

class E1160PopulationIncrease
{
    public static void Run()
    {
        /*
            * Growing rate of 2 cities (A and B)
            * A is the smaller city
            * We want to know how manny years it will take for city A to be bigger than city B
            * We'll only have results for cases where city A has a higher growth rate than city B
            * If the time is more than 100 years, just print the message: "Mais de 1 seculo"
        */
        
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        
        int totalTests, totalYears;
        string[] input;
        int populationCityA, populationCityB;
        double growthRateCityA, growthRateCityB;
        
        totalTests = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < totalTests; i++)
        {
            totalYears = 0;
            input = Console.ReadLine().Split(" ");
            populationCityA = int.Parse(input[0]);
            populationCityB = int.Parse(input[1]);
            growthRateCityA = double.Parse(input[2]);
            growthRateCityB = double.Parse(input[3]);
        
            do
            {
                populationCityA += (int) (populationCityA * growthRateCityA) / 100;
                populationCityB += (int) (populationCityB * growthRateCityB) / 100;
                totalYears++;
            } while (totalYears <= 100 && populationCityA <= populationCityB);
        
            if (totalYears > 100)
            {
                Console.WriteLine("Mais de 1 seculo.");
            }
            else
            {
                Console.WriteLine(totalYears + " anos.");
            }
        
        }

    }
}