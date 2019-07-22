using System;
using System.Collections.Generic;
namespace MerchantsOfGalaxy
{
    public class Class1
    {
        public static Dictionary<char, int> romanLiteralDict = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        public string RomanToDecimal(string romanStr)
        {
            if (!ValidRomanNumberCheck(romanStr))
                return "Incorrect Format";

            int romanStrLen = romanStr.Length, index1 = 0, index2 = 1, total = 0;

            while (index1 < romanStrLen)
            {

                if (index2 < romanStrLen && romanLiteralDict[romanStr[index1]] < romanLiteralDict[romanStr[index2]])
                {
                    total += romanLiteralDict[romanStr[index2]] - romanLiteralDict[romanStr[index1]];
                    index1 += 2;
                    index2 += 2;
                }
                else
                {
                    total += romanLiteralDict[romanStr[index1]];
                    ++index1;
                    ++index2;
                }
            }

            return total.ToString();
        }


        public static bool ValidRomanNumberCheck(string str)
        {
            if (str.Contains("IC") || str.Contains("IL") || str.Contains("ID") || str.Contains("IM"))
            {
                return false;
            }
            if (str.Contains("XM") || str.Contains("XD"))
            {
                return false;
            }
            if (str.Contains("VM") || str.Contains("LM") || str.Contains("DM") || str.Contains("VX"))
            {
                return false;
            }
            if (str.Contains("IIII") || str.Contains("XXXX") || str.Contains("CCCC") || str.Contains("MMMM"))
            {
                return false;
            }
            if (str.Contains("DD") || str.Contains("LL") || str.Contains("VV"))
            {
                return false;
            }
            return true;
        }
    }
}
