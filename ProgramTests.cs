using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testaufgabe;

namespace Testaufgabe.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ValueCheck_ValidRomanNumeral_ReturnsTrue()
        {
            Assert.IsTrue(Program.ValueCheck("XIV"));
        }

        [TestMethod]
        public void ValueCheck_InvalidRomanNumeral_ReturnsFalse()
        {
            Assert.IsFalse(Program.ValueCheck("XIVZ"));
        }

        [TestMethod]
        public void RomToInt_ValidRomanNumeral_ReturnsInteger()
        {
            Assert.AreEqual(14, Program.RomToInt("XIV"));
        }

        [TestMethod]
        public void RomToInt_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(0, Program.RomToInt(""));
        }

        [TestMethod]
        public void RomToInt_SingleCharacter_ReturnsCorrectValue()
        {
            Assert.AreEqual(1, Program.RomToInt("I"));
            Assert.AreEqual(5, Program.RomToInt("V"));
            Assert.AreEqual(10, Program.RomToInt("X"));
            Assert.AreEqual(50, Program.RomToInt("L"));
            Assert.AreEqual(100, Program.RomToInt("C"));
            Assert.AreEqual(500, Program.RomToInt("D"));
            Assert.AreEqual(1000, Program.RomToInt("M"));
        }
    }
}
