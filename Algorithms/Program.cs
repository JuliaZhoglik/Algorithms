using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string romanNumber = "MMXVIII";
                int result = RomanNumbers.RomanToInt(romanNumber);
                Console.WriteLine(romanNumber + " = {0}", result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string s = "((1+3)()(4+(3-5)))";
                bool check = Parentheses.CheckParentheses(s);
                Console.WriteLine(s + " in balance = {0}", check);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var list = new DoubleLinkedList<int>();
            list.AddLast(5);
            list.AddLast(10);
            list.AddFirst(2);
            list.AddFirst(1);

            Console.WriteLine("DoubleLinkedList");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count = {0}", list.Count);
            list.Reverse();
            Console.WriteLine("DoubleLinkedList.Reverse");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
