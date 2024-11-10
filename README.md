# Testaufgabe

Main Programcan be found in Testaufgabe -> Program.cs
Total time: 2h

This console application converts Roman numerals (like "XIV") into integer numbers (like 14). It includes functions to check if the input is valid and then convert it, along with tests to make sure everything works correctly.

Methods:
1. Input Validation (ValueCheck function) - checks if the input not empty and only contains valid Roman numeral characters (I, V, X, L, C, D, M). This step helps avoid errors by making sure only correct characters are processed.
2.Roman Numeral Conversion (RomToInt function) - goes through each character in the Roman numeral, turning it into a number using a helper function. The function adjusts for cases where a smaller numeral comes before a larger one (e.g., "IV" should be 4, not 6).
3. Helper Function (RomanValue function)- matches each Roman numeral letter to its integer value. This makes it easier to update or check values in one place.

Progress:
From the very beginning I had an algorithm in my head where the program checks each character and if it turns out to be I, X or C then it also writes the next character into a variable and then checks the combination of these characters in switch. After I found a regularity in which if the next number is greater than the current number, it is enough to subtract from the next number the current number to get a integer number corresponding to the Roman number, so I changed the method romToInt().
I also tried to create a unit test, since I did it for the first time it took more time. This test can be found in RomanNumeralTests -> UnitTest1.cs
