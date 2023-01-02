using System.Globalization;

namespace GitHubFiles.Exercises;

class E1040Average03
{
    public static void Run()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        string[] input;
        double gradeA, gradeB, gradeC, gradeD, gradeExam, average;

        input = Console.ReadLine().Split(" ");
        gradeA = double.Parse(input[0]);
        gradeB = double.Parse(input[1]);
        gradeC = double.Parse(input[2]);
        gradeD = double.Parse(input[3]);

        average = Math.Truncate(gradeA * 2 + gradeB * 3 + gradeC * 4 + gradeD * 1) / 10;
        Console.WriteLine("Media: {0}", average.ToString("0.0"));

        if(average >= 7)
        {
            Console.WriteLine("Aluno aprovado.");
        } 
        else if(average < 5)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            gradeExam = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: {0}", average.ToString("0.0"));

            average = (average + gradeExam) / 2;

            if(average >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine("Media final: {0}", average.ToString("0.0"));
        }
    }
}