using System;
using System.Collections.Generic;
namespace MerchantsOfGalaxy
{
    public class Galaxy
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

        public int RomanToDecimal(string romanStr)
        {
            if (!ValidRomanNumberCheck(romanStr))
                return -1;

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

            return total;
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

        static Dictionary<string, string> stringForRomanLiteralDict = new Dictionary<string, string>();
        static Dictionary<string, int> metalValueDict = new Dictionary<string, int>();

        public string[] inputTest = new string[] {
            "glob is I",
            "prok is V",
            "pish is X",
            "tegj is L",
            "glob glob Silver is 34 Credits",
            "glob prok Gold is 57800 Credits",
            "pish pish Iron is 3910 Credits",
            "how much is pish tegj glob glob ?",
            "how many Credits is glob prok Silver?",
            "how many Credits is glob prok Gold?",
            "how many Credits is glob prok Iron?",
            "how much wood could a woodchuck chuck if a woodchuck could chuck wood?"
        };

        public void TestTokenization()
        {

            string[] temp;
            int tempIndex;

            foreach (string testString in inputTest)
            {
                temp = testString.Split(' ');
                if (Array.IndexOf(temp, "Credits") > Array.IndexOf(temp, "is"))
                {
                    // get values of metals
                    tempIndex = Array.IndexOf(temp, "is") - 1;
                    metalValueDict.Add(temp[tempIndex], getMetalValue(temp, tempIndex));
                }
                else if (Array.IndexOf(temp, "Credits") < Array.IndexOf(temp, "is"))
                {
                    // store queries
                }
                else
                {
                    // initialize each roman literal with given string
                    stringForRomanLiteralDict.Add(temp[0], temp[2]);
                }
            }

        }

        public int getMetalValue(string[] valArr, int limitIndex)
        {
            string currRomanValue = "";

            for (int index = 0; index < limitIndex; ++limitIndex)
            {
                currRomanValue += stringForRomanLiteralDict[valArr[index]];
            }
            return RomanToDecimal(currRomanValue);
        }
    }
}
