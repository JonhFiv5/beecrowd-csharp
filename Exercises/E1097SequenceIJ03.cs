namespace GitHubFiles.Exercises;

class E1097SequenceIJ03
{
    public static void Run()
    {
        int jAux = 7;

        for (int i = 1; i <= 9; i+=2)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"I={i} J={jAux - j}");
            }
            jAux += 2;
        }

    }
}