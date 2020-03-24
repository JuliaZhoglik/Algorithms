using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class RomanNumbers
    {
        private enum RomanNumeral
        {
            I = 1, IV = 4, V = 5, IX = 9, X = 10,
            XL = 40, L = 50, XC = 90, C = 100,
            CD = 400, D = 500, CM = 900, M = 1000
        }

        static private List<RomanNumeral> GetReverseSortedValues()
        {
            List<RomanNumeral> listNumeral = Enum.GetValues(typeof(RomanNumeral)).OfType<RomanNumeral>().ToList();
            listNumeral.Sort();
            listNumeral.Reverse();
            return listNumeral;
        }


        static public int RomanToInt(string s)
        {
            string romanNumber = s.ToUpper();
            int result = 0;

            List<RomanNumeral> romanNumerals = GetReverseSortedValues();

            int i = 0;
            while ((romanNumber.Length > 0) && (i < romanNumerals.Count))
            {
                RomanNumeral symbol = romanNumerals[i];
                string nameSymbol = Enum.GetName(typeof(RomanNumeral), symbol);
                if (romanNumber.StartsWith(nameSymbol))
                {
                    result += (int)symbol;
                    romanNumber = romanNumber.Substring(nameSymbol.Length);
                }
                else
                {
                    i++;
                }
            }

            if (romanNumber.Length > 0)
            {
                throw new Exception(s + " cannot be converted to integer.");
            }

            if ((result <= 0) || (result > 3000))
            {
                throw new Exception("Roman number can be in range (0,3000]");
            }

            return result;
        }
    }
}
