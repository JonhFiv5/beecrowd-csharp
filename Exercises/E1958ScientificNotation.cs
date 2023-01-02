namespace GitHubFiles.Exercises;

class E1958ScientificNotation
{
    public static void Run()
    {
        string number, integerPart, decimalPart, mantissa, notation, exponent = "+00", mantissaSign = "+";
        int startNotationIndex, startDecimalIndex, numberOriginalLength;
        
        number = Console.ReadLine();
        
        if (number[0] == '-')
        {
            mantissaSign = "-";
            number = number.Substring(1);
        }
        
        // Getting some info about the read number
        startNotationIndex = getFirstNotationNumberIndex(number);
        startDecimalIndex = getFirstDecimalIndex(number);
        
        numberOriginalLength = number.Replace(".", "").Length;
        
        // Forming the mantissa
        
        if (startDecimalIndex != -1)
        {
            integerPart = number.Split(".")[0];
            decimalPart = number.Split(".")[1];
            decimalPart = formatDecimalPart(decimalPart);
            number = integerPart + decimalPart;
        }
        
        mantissa = number.Substring(startNotationIndex).Replace(".", "");
        mantissa = mantissa.PadRight(5, '0');
        mantissa = mantissa.Substring(0, 5).Insert(1, ".");
        
        // Getting the exponent
        if (startDecimalIndex != -1)
        {
            if (startNotationIndex < startDecimalIndex)
            {
                // Case 1. Number with decimal places and an integer part
                exponent = "+" + (startDecimalIndex - 1).ToString().PadLeft(2, '0');
                Console.WriteLine("Case 1");
            }
            else
            {
                exponent = "-" + (startDecimalIndex - startNotationIndex).ToString().Replace("-", "").PadLeft(2, '0');
                Console.WriteLine("Case 2");
            }
        }
        else
        {
                exponent = "+" + (numberOriginalLength - 1).ToString().PadLeft(2, '0');
                Console.WriteLine("Case 3");
        }
        
        notation = mantissaSign + mantissa + "E" + exponent;
        Console.WriteLine(notation);
        
        
        // Methods ----------------------------------------------------------------------------------
        string formatDecimalPart(string decimalPart)
        {
            string formatedDecimalPart = decimalPart;
        
            if (decimalPart.Length > 4)
            {
                decimalPart = decimalPart.Substring(0, 4) + "," + decimalPart[4];
                formatedDecimalPart = $"{(int) Math.Round(float.Parse(decimalPart))}";
            }
        
            return formatedDecimalPart;
        }
        
        int getFirstNotationNumberIndex(string value)
        {
            int firstNotationNumberIndex = 0;
        
            for (int i = 0; i < value.Length; i++)
            {
                char currentChar = value[i];
                if (Char.IsDigit(currentChar) && currentChar != '0')
                {
                    firstNotationNumberIndex = i;
                    break;    
                }
            }   
        
            return firstNotationNumberIndex;
        }
        
        
        int getFirstDecimalIndex(string value)
        {
            int firstDecimalIndex = -1;
        
            for (int i = 0; i < value.Length; i++)
            {
                char currentChar = value[i];
                if (currentChar == '.')
                {
                    firstDecimalIndex = i;
                    break;    
                }
            }   
        
            return firstDecimalIndex;
        }

    }
}