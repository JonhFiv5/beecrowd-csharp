namespace GitHubFiles.Exercises;

class E1961JumpingFrog
{
    public static void Run()
    {
        int jumpHeight, pipeHeight, pipeJumpDifference;
        string[] input;
        int[] pipes;
        string result;
        
        input = Console.ReadLine().Split(" ");
        jumpHeight = int.Parse(input[0]);
        
        pipes = Array.ConvertAll(Console.ReadLine().Split(" "), element => int.Parse(element));
        
        result = "YOU WIN";
        foreach (int pipe in pipes)
        {
            pipeJumpDifference = Math.Abs(pipe - jumpHeight);
            if (pipeJumpDifference > jumpHeight)
            {
                result = "GAME OVER";
            }
        }
        
        Console.WriteLine(result);
    }
}