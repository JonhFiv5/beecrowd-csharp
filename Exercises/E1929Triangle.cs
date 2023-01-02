namespace GitHubFiles.Exercises;

class E1929Triangle
{
    public static void Run()
    {
        string[] input;
        int a, b, c, d;
        bool result = false;
        
        input = Console.ReadLine().Split(" ");
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
        c = int.Parse(input[2]);
        d = int.Parse(input[3]);
        
        result = isTrianglePossible(a, b, c) ||
            isTrianglePossible(a, b, d) || 
            isTrianglePossible(a, c, d) || 
            isTrianglePossible(b, c, d);
        
        Console.WriteLine(result ? "S":"N");
        
        
        bool isTrianglePossible(int a, int b, int c)
        {
            bool possible;
        
            if ((Math.Abs(b - c) < a) && (a < b + c))
            {
                possible = true;
            }
            else if ((Math.Abs(a - c) < b) && (b < a + c))
            {
                possible = true;
            }
            else if ((Math.Abs(a - b) < c) && (c < a + b))
            {
                possible = true;
            }
            else
            {
                possible = false;
            }
        
            return possible;
        }
        

    }
}