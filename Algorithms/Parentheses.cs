using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Parentheses
    {
        static public bool CheckParentheses(string s)
        {
            if (s.Length == 0)
            {
                throw new Exception("Input string cannot be empty.");
            }

            bool check = false;
            int countOpen = 0;

            foreach (char ch in s)
            {
                if (ch == '(')
                {
                    countOpen++;
                }
                else if (ch == ')')
                {
                    countOpen--;
                }

                if (countOpen < 0)
                {
                    break;
                }
            }

            if (countOpen == 0)
            {
                check = true;
            }

            return check;
        }
    }
}
