namespace GitHubFiles.Exercises;

class E1114FixedPassword
{
    public static void Run()
    {
        string input, password = "2002";

        while (true)
        {
            input = Console.ReadLine();
            if (input == password)
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else
            {
                Console.WriteLine("Senha Invalida");
            }
        }
    }
}