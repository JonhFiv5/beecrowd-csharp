namespace GitHubFiles.Exercises;

class E1864NossosDiasNuncaVoltarao
{
    public static void Run()
    {
        int totalChars;
        string phrase = "LIFE IS NOT A PROBLEM TO BE SOLVED";
        
        totalChars = int.Parse(Console.ReadLine());
        Console.WriteLine(phrase.Substring(0, totalChars));

    }
}