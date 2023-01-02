namespace GitHubFiles.Exercises;

class E1848CorvoContador
{
    public static void Run()
    {
        int result = 0, totalScreams = 0;
        string input;
        
        while (totalScreams < 3)
        {
            input = Console.ReadLine();
        
            if (input == "caw caw") {
                Console.WriteLine(result);
                result = 0;
                totalScreams++;
            } 
            else
            {
                result += blinkToDecimal(input);
            }
        
        }
        
        int blinkToDecimal(string blink)
        {
            int decValue = 0;
        
            decValue += blink[0] == '*' ? 4 : 0;
            decValue += blink[1] == '*' ? 2 : 0;
            decValue += blink[2] == '*' ? 1 : 0;
        
            return decValue;
        }
    }
}