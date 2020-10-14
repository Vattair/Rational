using Microsoft.VisualStudio.TestTools.UnitTesting;
using RationalLib;

namespace RationalUnitTest
{
    [TestClass]
    public class Rational32UnitTest
    {
        [DataTestMethod]
        [DataRow(1, 2, 1, 2)]
        [DataRow(2, 4, 1, 2)]
        [DataRow(-3, 4, -3, 4)]
        [DataRow(-3, -4, 3, 4)]
        [DataRow(3, -4, -3, 4)]
        [DataRow(0, 5, 0, 1)]
        [DataRow(0, -2, 0, 1)]
        public void KonstruktorDwuArgumentowy_Poprawnie(int numerator, int denominator, int expectedNumerator, int expectedDenominator)
        {
            //AAA
            Rational32 u = new Rational32(numerator, denominator);
            Assert.AreEqual(expectedNumerator, u.Numerator);
            Assert.AreEqual(expectedDenominator, u.Denominator);
        }
    }
}
