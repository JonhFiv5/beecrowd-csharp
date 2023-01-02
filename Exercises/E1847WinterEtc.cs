namespace GitHubFiles.Exercises;

class E1847WinterEtc
{
    public static void Run()
    {
        string[] input;
        string[] humorList = {":(", ":)"};
        int humor = 0;
        int dayOne, dayTwo, dayThree;
        
        input = Console.ReadLine().Split(" ");
        
        dayOne = int.Parse(input[0]);
        dayTwo = int.Parse(input[1]);
        dayThree = int.Parse(input[2]);
        
        // Temperature decreased from day one to day two
        if (dayOne > dayTwo)
        {
            if (dayTwo <= dayThree)
            {
                humor = 1;
            }
            else if (dayTwo > dayThree)
            {
                if ((dayTwo - dayThree) < (dayOne - dayTwo))
                {
                    humor = 1;
                }
                else if ((dayTwo - dayThree) >= (dayOne - dayTwo))
                {
                    humor = 0;
                }
            }
        }
        // Temperature increased from day one to day two
        else if (dayOne < dayTwo)
        {
            if (dayTwo >= dayThree)
            {
                humor = 0;
            }
            else if (dayTwo < dayThree)
            {
                if ((dayThree - dayTwo) < (dayTwo - dayOne))
                {
                    humor = 0;
                }
                else if ((dayThree - dayTwo) >= (dayTwo - dayOne))
                {
                    humor = 1;
                }
            }
        }
        // Temperature remained constant from day one to day two
        else
        {
            if (dayTwo < dayThree)
            {
                humor = 1;
            }
            else
            {
                humor = 0;
            }
        }
        
        Console.WriteLine(humorList[humor]);
    }
}