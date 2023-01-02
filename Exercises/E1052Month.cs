namespace GitHubFiles.Exercises;

class E1
{
    public static void Run()
    {
        string[] months = {"January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"};
        int input;

        input = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine(months[input]);

    }
}