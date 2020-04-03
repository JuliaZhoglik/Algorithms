using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System.Collections;

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

        [TestMethod]
        public void TestMethodDoubleLinkedList()
        {
            ArrayList expected = new ArrayList();
            expected.Add(1);
            expected.Add(2);
            expected.Add(5);
            expected.Add(10);

            var list = new DoubleLinkedList<int>();
            list.AddLast(5);
            list.AddLast(10);
            list.AddFirst(2);
            list.AddFirst(1);

            ArrayList actual = new ArrayList();
            foreach (var item in list)
            {
                actual.Add(item);
            }

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodDoubleLinkedListReverse()
        {
            ArrayList expected = new ArrayList();
            expected.Add(10);
            expected.Add(5);
            expected.Add(2);
            expected.Add(1);

            var list = new DoubleLinkedList<int>();
            list.AddLast(5);
            list.AddLast(10);
            list.AddFirst(2);
            list.AddFirst(1);
            list.Reverse();

            ArrayList actual = new ArrayList();
            foreach (var item in list)
            {
                actual.Add(item);
            }

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
