namespace GitHubFiles.Exercises;

class E1035SelectionTest01
{
    public static void Run()
    {
        /*
        Conditions:
        * B greater than C 
        * D greater than A
        * C + D greater than A + B
        * C and D positive
        * A even
        */

        int a, b, c, d;
        string[] input;

        input = Console.ReadLine().Split(" ");

        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
        c = int.Parse(input[2]);
        d = int.Parse(input[3]);

        bool condition = false;
        condition = b > c;
        condition = (d > a) && condition;
        condition = (c + d > a + b) && condition;
        condition = (c >= 0 && d >= 0) && condition;
        condition = (a % 2 == 0) && condition;

        if (condition)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }

    }
}