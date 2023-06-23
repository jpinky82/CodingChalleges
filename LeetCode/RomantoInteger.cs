using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RomantoInteger
    {
        static void Main(string[] args)
        {
            /*
            * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

                        Symbol       Value
                        I             1
                        V             5
                        X             10
                        L             50
                        C             100
                        D             500
                        M             1000

            For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

            Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

            I can be placed before V (5) and X (10) to make 4 and 9. 
            X can be placed before L (50) and C (100) to make 40 and 90. 
            C can be placed before D (500) and M (1000) to make 400 and 900.
            Given a roman numeral, convert it to an integer.

            Example 1:

            Input: s = "III"
            Output: 3
            Explanation: III = 3.
            Example 2:

            Input: s = "LVIII"
            Output: 58
            Explanation: L = 50, V= 5, III = 3.
            Example 3:

            Input: s = "MCMXCIV"
            Output: 1994
            Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 
            Constraints:

            1 <= s.length <= 15
            s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
            It is guaranteed that s is a valid roman numeral in the range [1, 3999].
            * 
            */

            Console.WriteLine(RomanToInt("MCMXCIV"));
        }


        //Luke's Solution
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanNum = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',50 },
                {'D',500 },
                {'M',1000 }
            };
            int sum = romanNum[s.LastOrDefault()];

            for (int i = s.Length-2; i>= 0; --i)
            {
                if (romanNum[s[i]] < romanNum[s[i + 1]])
                {
                    sum -= romanNum[s[i]];
                }
                else
                {
                    sum += romanNum[s[i]];
                }
            }
            return sum;
        }


        //My Initial solution
        //public static int RomanToInt(string s)
        //{
        //    string userInput = s.ToLower();
        //    int num = 0;
        //    bool vandx = false;
        //    bool landc = false;
        //    bool dandm = false;

        //    for (int i = 0; i < userInput.Length; i++)
        //    {
        //        switch (userInput[i])
        //        {
        //            case 'i':
        //                if (i < userInput.Length - 1 && (userInput[i + 1] == 'v' || userInput[i + 1] == 'x'))
        //                {
        //                    vandx = true;
        //                    if (userInput[i + 1] == 'v') { num += 4; }

        //                    else { num += 9; }
        //                    break;
        //                }
        //                num += 1;

        //                break;
        //            case 'v':
        //                if (vandx)
        //                {
        //                    vandx = false;
        //                    break;
        //                }

        //                num += 5;
        //                break;
        //            case 'x':
        //                if (vandx)
        //                {
        //                    vandx = false;
        //                    break;
        //                }
        //                if (i < userInput.Length - 1 && (userInput[i + 1] == 'l' || userInput[i + 1] == 'c'))
        //                {
        //                    landc = true;
        //                    if (userInput[i + 1] == 'l') { num += 40; }

        //                    else { num += 90; }
        //                    break;
        //                }
        //                num += 10;

        //                break;
        //            case 'l':
        //                if (landc)
        //                {
        //                    landc = false;
        //                    break;
        //                }
        //                num += 50;
        //                break;
        //            case 'c':
        //                if (landc)
        //                {
        //                    landc = false;
        //                    break;
        //                }
        //                if (i < userInput.Length - 1 && (userInput[i + 1] == 'd' || userInput[i + 1] == 'm'))
        //                {
        //                    dandm = true;
        //                    if (userInput[i + 1] == 'd') { num += 400; }

        //                    else { num += 900; }
        //                    break;
        //                }
        //                num += 100;
        //                break;
        //            case 'd':
        //                if (dandm)
        //                {
        //                    dandm = false;
        //                    break;
        //                }
        //                num += 500;
        //                break;
        //            case 'm':
        //                if (dandm)
        //                {
        //                    dandm = false;
        //                    break;
        //                }
        //                num += 1000;
        //                break;
        //            default:
        //                return 0;
        //        }
        //    }
        //    return num;


        //}
        /*******************************************************
         *        A more civilized answer from Leetcode
         *******************************************************/
        //public static int RomanToInt(string s)
        //{

        //    var chars = s.ToCharArray();
        //    var result = 0;
        //    var currentValue = 0;
        //    for (var i = 0; i < chars.Length - 1; i++)
        //    {
        //        currentValue = RomanNumerals(chars[i]);
        //        result += (RomanNumerals(chars[i + 1]) > currentValue ? -1 : 1) * currentValue;
        //    }

        //    return result + RomanNumerals(chars[chars.Length - 1]);
        //}

        //public static int RomanNumerals(char c)
        //{
        //    switch (c)
        //    {
        //        case 'I': return 1;
        //        case 'V': return 5;
        //        case 'X': return 10;
        //        case 'L': return 50;
        //        case 'C': return 100;
        //        case 'D': return 500;
        //        case 'M': return 1000;
        //    };
        //    return 0;
        //}
    }
}
