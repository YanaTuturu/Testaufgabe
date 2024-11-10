using Xunit; 
using Testaufgabe;  

namespace RomanNumeralTests
{
    public class RomanNumeralTests
    {
        [Fact]
        public void ValueCheck_ValidRomanNumeral_ReturnsTrue()
        {
            Assert.True(Program.ValueCheck("IV"));
        }

        [Fact]
        public void ValueCheck_InvalidRomanNumeral_ReturnsFalse()
        {
            Assert.False(Program.ValueCheck("A"));
        }
        [Fact]
        public void RomToInt_ValidRomanNumeral_ReturnsCorrectInteger()
        {
            Assert.Equal(4, Program.RomToInt("IV"));
            Assert.Equal(9, Program.RomToInt("IX"));
        }

        [Fact]
        public void RomToInt_InvalidRomanNumeral_ReturnsZero()
        {
            Assert.Equal(0, Program.RomToInt("A"));
        }
    }
}
