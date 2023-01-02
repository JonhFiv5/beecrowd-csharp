using System.Globalization;

namespace GitHubFiles.Exercises;

class E1043Triangle
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        string[] input;
        float aSide, bSide, cSide, trapeziumArea, trianglePerimeter;

        input = Console.ReadLine().Split(" ");
        aSide = float.Parse(input[0]);
        bSide = float.Parse(input[1]);
        cSide = float.Parse(input[2]);

        bool aCondition = Math.Abs(bSide - cSide) < aSide && aSide < bSide + cSide;
        bool bCondition = Math.Abs(aSide - cSide) < bSide && bSide < aSide + cSide;
        bool cCondition = Math.Abs(aSide - bSide) < cSide && cSide < aSide + bSide;

        if (aCondition && bCondition && cCondition)
        {
            trianglePerimeter = aSide + bSide + cSide;
            Console.WriteLine("PERIMETRO = {0}", trianglePerimeter.ToString("0.0"));
        }
        else
        {
            trapeziumArea = ((aSide + bSide) * cSide) / 2;
            Console.WriteLine("AREA = {0}", trapeziumArea.ToString("0.0"));
        }
    }
}