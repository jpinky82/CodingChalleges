using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PalindromeNumber
    {
        static void Main(string[] args)
        {

            //Given an integer x, return true if x is a
            //palindrome
            //, and false otherwise.



            //Example 1:

            //Input: x = 121
            //Output: true
            //Explanation: 121 reads as 121 from left to right and from right to left.
            //Example 2:

            //Input: x = -121
            //Output: false
            //Explanation: From left to right, it reads - 121.From right to left, it becomes 121 -.Therefore it is not a palindrome.
            //Example 3:

            //Input: x = 10
            //Output: false
            //Explanation: Reads 01 from right to left.Therefore it is not a palindrome.


            //Constraints:

            //            -231 <= x <= 231 - 1



            //Follow up: Could you solve it without converting the integer to a string?

            Console.WriteLine(IsPalindrome(1234567899));
            //getting an error at this number

        }
        public static bool IsPalindrome(int x)
        {
            if (x >= 0)
            {
                string num = x.ToString();
                string[] length = new string[num.Length];
                string newstring = "";

                for (int i = 0; i < num.Length; i++)
                {
                    length[i] = num.Substring(i,1);
                }
                Array.Reverse(length);
                for (int j = 0; j < length.Length; j++)
                {
                    newstring = $"{newstring}{length[j]}";
                }

                if (Convert.ToInt64(newstring) == x)
                {
                    return true;
                }
            }
            return false;

            //Leetcode Solution
            // Special cases:
            // As discussed above, when x < 0, x is not a palindrome.
            // Also if the last digit of the number is 0, in order to be a palindrome,
            // the first digit of the number also needs to be 0.
            // Only 0 satisfy this property.

            //***********************************************************
            //if (x < 0 || (x % 10 == 0 && x != 0))
            //{
            //    return false;
            //}

            //int revertedNumber = 0;
            //while (x > revertedNumber)
            //{
            //    revertedNumber = revertedNumber * 10 + x % 10;
            //    x /= 10;
            //}
            //************************************************************

            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.

            //*************************************************************
            //return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
