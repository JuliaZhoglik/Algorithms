using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            Console.ReadLine();
        }
    }
}
