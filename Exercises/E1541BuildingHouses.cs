namespace GitHubFiles.Exercises;

class E1541BuildingHouses
{
    public static void Run()
    {
        string input;
        string[] inputData;
        int houseBase, houseHeight, houseArea, terrainSide, allowedBuildPercentage;
        double terrainArea;
        
        while (true)
        {
            input = Console.ReadLine();
            if (input == "0")
            {
                break;
            }
        
            inputData = input.Split(" ");
            houseBase = int.Parse(inputData[0]);
            houseHeight = int.Parse(inputData[1]);
            allowedBuildPercentage = int.Parse(inputData[2]);
        
            houseArea = houseBase * houseHeight;
            /*
                100 metros quadrados
                Pode construir 40%
                Terreno vai precisar ter: 200 metros quadrados
            */
            terrainArea = (100.0 / (double) allowedBuildPercentage) * houseArea;
            terrainSide = (int) Math.Sqrt(terrainArea);
        
            Console.WriteLine(terrainSide);
        }
    }
}