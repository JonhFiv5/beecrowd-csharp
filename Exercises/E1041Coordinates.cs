namespace GitHubFiles.Exercises;

class E1041Coordinates
{
    public static void Run()
    {
        string[] input;
        string coordinatePosition;
        float xAxis, yAxis;

        input = Console.ReadLine().Split(" ");

        xAxis = float.Parse(input[0]);
        yAxis = float.Parse(input[1]);

        if (xAxis == 0 && yAxis == 0)
        {
            coordinatePosition = "Origem";
        }
        else if (xAxis == 0)
        {
            coordinatePosition = "Eixo Y";
        }
        else if (yAxis == 0)
        {
            coordinatePosition = "Eixo X";
        }
        else if (xAxis > 0 && yAxis > 0)
        {
            coordinatePosition = "Q1";
        }
        else if (xAxis < 0 && yAxis > 0)
        {
            coordinatePosition = "Q2";
        }
        else if (xAxis < 0 && yAxis < 0)
        {
            coordinatePosition = "Q3";
        }
        else
        {
            coordinatePosition = "Q4";
        }

        Console.WriteLine(coordinatePosition);
    }
}