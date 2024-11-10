using System;
using System.ComponentModel.DataAnnotations;

namespace Testaufgabe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string? number = Console.ReadLine();

            // Validate the input and convert if valid
            if (ValueCheck(number))
            {
                int output = RomToInt(number);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid Roman number!");
            }
        }

        //Checking if the input string contains only valid Roman numeral characters
        public static bool ValueCheck(string? input)
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
        public static int RomToInt(string romNum)
        {
            int intNum = 0;
            for (int i = 0; i < romNum.Length; i++)
            {
                int currentVal = RomanValue(romNum[i]);
                int nextVal;

                // Determine the value of the next Roman numeral character, if it exists
                if (i + 1 < romNum.Length)
                {
                    nextVal = RomanValue(romNum[i + 1]);
                }
                else
                {
                    nextVal = 0;
                }

                // If the current value is less than the next value, subtract the current value from the next value
                // and add the result to the total, then skip the next character
                if (currentVal < nextVal)
                {
                    intNum += (nextVal - currentVal);
                    i++;
                }
                // Otherwise, just add the current value to the total
                else
                {
                    intNum += currentVal;
                }
            }
            return intNum;
        }

        // Method to get the integer value of a Roman numeral character or combination
        public static int RomanValue(char Num)
        {
            return Num switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0,
            };
        }
    }
}
