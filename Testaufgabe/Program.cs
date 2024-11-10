using System.ComponentModel.DataAnnotations;

namespace Testaufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string? number = Console.ReadLine();

            // Validate the input and convert if valid
            if (ValueCheck(number))
            {
                int output = romToInt(number);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid Roman number!");
            }
        }

        //Checking if the input string contains only valid Roman numeral characters
        public static bool ValueCheck (string? input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            foreach (char c in input)
            {
                if (!"IVXLCDM".Contains(c))
                    return false;
            }
            return true;
        }

        //Convert a Roman numeral to an integer
        public static int romToInt( string romNum)
        {
            int intNum = 0;
            for (int i = 0; i<romNum.Length; i++)
            {
                // Check for subtractive combinations (for example IV, IX)
                if ("IXC".Contains(romNum[i]) && (i + 1 < romNum.Length) && (romNum[i] != romNum[i+1]))
                {
                    string singleValue = romNum[i].ToString() + romNum[i + 1];
                    intNum += RomanValue(singleValue);
                    i++; // Skip the next character as it is part of the current combination
                }
                else
                {
                    intNum += RomanValue(romNum[i].ToString());
                }
            }
            return intNum;
        }

        // Method to get the integer value of a Roman numeral character or combination
        public static int RomanValue(string Num)
        {
            return Num switch
            {
                "I" => 1,
                "IV" => 4,
                "V" => 5,
                "IX" => 9,
                "X" => 10,
                "XL" => 40,
                "L" => 50,
                "XC" => 90,
                "C" => 100,
                "CD" => 400,
                "D" => 500,
                "CM" => 900,
                "M" => 1000,
                _ => 0,
            };
        }
    }
}
