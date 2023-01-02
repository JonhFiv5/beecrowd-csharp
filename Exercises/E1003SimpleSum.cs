namespace GitHubFiles.Exercises;

class E1003SimpleSum
{
    public static void Run()
    {
        int a, b, soma;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        soma = a + b;

        Console.WriteLine("SOMA = " + soma);
    }
}