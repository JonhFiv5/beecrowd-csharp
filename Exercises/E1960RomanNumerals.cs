namespace GitHubFiles.Exercises;

class E1960RomanNumerals
{
    public static void Run()
    {
        int decimalNumber, units, tens, hundreds;
        string romanNumber;
        string[] romanHundreds = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
        string[] romanTens = {"", "X", "XX", "XX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
        string[] romanUnits = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
        
        decimalNumber = int.Parse(Console.ReadLine());
        
        hundreds = decimalNumber / 100;
        decimalNumber -= hundreds * 100;
        
        tens = decimalNumber / 10;
        decimalNumber -= tens * 10;
        
        units = decimalNumber;
        
        romanNumber = romanHundreds[hundreds] + romanTens[tens] + romanUnits[units];
        
        Console.WriteLine(romanNumber);
        
        
        
        
        
        
        
        
        
        
        
        
        

    }
}