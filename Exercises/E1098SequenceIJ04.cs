using System.Globalization;

namespace GitHubFiles.Exercises;

class E1098SequenceIJ04
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        double jAux = 1;
        for (double i = 0; i <= 2; i+=0.2)
        {
            i = Math.Round(i, 2);
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"I={i} J={jAux + j}");
            }
            jAux = Math.Round(jAux + 0.2, 2);
        }
    }
}