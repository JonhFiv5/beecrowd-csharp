namespace GitHubFiles.Exercises;

class E1004SimpleProduct
{
    public static void Run()
    {
        int a, b, prod;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        prod = a * b;

        Console.WriteLine("PROD = " + prod);
    }
}