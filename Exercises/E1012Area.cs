using System.Globalization;

namespace GitHubFiles.Exercises;

class E1012Area
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        const double PI = 3.14159;
        string[] input;
        double a, b, c, triangleArea, circleArea, trapeziumArea, squareArea, rectangleArea;


        input = Console.ReadLine().Split(" ");

        a = double.Parse(input[0]);
        b = double.Parse(input[1]);
        c = double.Parse(input[2]);

        triangleArea = Math.Round((a * c) / 2, 3);
        circleArea = Math.Round(PI * (c * c), 3);
        trapeziumArea = Math.Round(((a + b) * c) / 2, 3);
        squareArea = Math.Round(b * b, 3);
        rectangleArea = Math.Round(a * b, 3);

        Console.WriteLine("TRIANGULO: {0}", triangleArea.ToString("N3"));
        Console.WriteLine("CIRCULO: {0}", circleArea.ToString("N3"));
        Console.WriteLine("TRAPEZIO: {0}", trapeziumArea.ToString("N3"));
        Console.WriteLine("QUADRADO: {0}", squareArea.ToString("N3"));
        Console.WriteLine("RETANGULO: {0}", rectangleArea.ToString("N3"));
    }
}