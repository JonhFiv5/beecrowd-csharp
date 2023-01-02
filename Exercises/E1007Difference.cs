namespace GitHubFiles.Exercises;

class E1007Difference
{
    public static void Run()
    {
        int ConvertInput(string? input) {
            if (input != null) {
                return int.Parse(input);
            }
            return 0;
        }

        int a, b, c, d, difference;

        a = ConvertInput(Console.ReadLine());
        b = ConvertInput(Console.ReadLine());
        c = ConvertInput(Console.ReadLine());
        d = ConvertInput(Console.ReadLine());

        difference = a * b - c * d;

        Console.WriteLine("DIFERENCA = {0}", difference);
    }
}