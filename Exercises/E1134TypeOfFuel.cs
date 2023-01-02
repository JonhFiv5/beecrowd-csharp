namespace GitHubFiles.Exercises;

class E1134TypeOfFuel
{
    public static void Run()
    {
        // alcohol = i[0], gasoline = i[1], diesel = i[2]
        int[] fuelOptions = {0, 0, 0};
        int input;

        while (true)
        {
            do
            {
                input = int.Parse(Console.ReadLine());
            } while ((input < 0) || (input > 4));

            if (input == 4)
            {
                break;
            }

            fuelOptions[input-1] += 1;
        }

        Console.WriteLine(
            "MUITO OBRIGADO\n" +
            $"Alcool: {fuelOptions[0]}\n" +
            $"Gasolina: {fuelOptions[1]}\n" +
            $"Diesel: {fuelOptions[2]}"
        );
    }
}