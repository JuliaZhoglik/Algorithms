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



            Console.ReadLine();
        }
    }
}
