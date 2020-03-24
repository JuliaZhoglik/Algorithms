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

        [TestMethod]
        public void TestMethodParenthesesTrue()
        {
            string s = "((1+3)()(4+(3-5)))";
            bool inBalance = true;
            bool result = Parentheses.CheckParentheses(s);
            Assert.AreEqual(inBalance, result);
        }

        [TestMethod]
        public void TestMethodParenthesesFalse()
        {
            string s = "((1+3)((4+(3-5)))";
            bool inBalance = false;
            bool result = Parentheses.CheckParentheses(s);
            Assert.AreEqual(inBalance, result);
        }
    }
}
