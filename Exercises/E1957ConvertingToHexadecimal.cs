namespace GitHubFiles.Exercises;

class E1957ConvertingToHexadecimal
{
    public static void Run()
    {
        // Easy method -------------------------------------------------------------------------
        int decNumber;
        
        decNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine(decNumber.ToString("X"));
        
        // Manual method -------------------------------------------------------------------------
        string[] hexValues = {
            "0", "1", "2", "3",
            "4", "5", "6", "7",
            "8", "9", "A", "B",
            "C", "D", "E", "F"
        };
        string hexNumber = "";
        int dividend = decNumber;
        int quotient;
        int remainder;
        
        do
        {
            quotient = dividend / 16;
            remainder = dividend - (quotient * 16);
            hexNumber += hexValues[remainder];
        
            dividend = quotient; 
        } while (quotient != 0);
        
        Console.WriteLine(hexNumber.Reverse().ToArray());

    }
}