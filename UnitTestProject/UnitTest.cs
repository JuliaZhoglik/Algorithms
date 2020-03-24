using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodRomanNumbers()
        {
            string romanNumber = "MMXVIII";
            int number = 2018;
            int result = RomanNumbers.RomanToInt(romanNumber);
            Assert.AreEqual(number, result);
        }
    }
}
