using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LongestCommonPrefixProb
    {
        static void Main(string[] args)
        {


            /*
            Write a function to find the longest common prefix string amongst an array of strings.

            If there is no common prefix, return an empty string "".



            Example 1:

            Input: strs = ["flower","flow","flight"]
            Output: "fl"
            Example 2:

            Input: strs = ["dog","racecar","car"]
            Output: ""
            Explanation: There is no common prefix among the input strings.


            Constraints:

            1 <= strs.length <= 200
            0 <= strs[i].length <= 200
            strs[i] consists of only lowercase English letters.
             */
            string[] strs = { "flower", "flow", "", "fight", "fig" };

            Console.WriteLine(LongestCommonPrefix(strs));


        }
        public static string LongestCommonPrefix(string[] strs)
        {
            
            
            if(strs.Length == 0) { return ""; }
            if(strs.Length == 1) { return strs[0]; }

            string result = "";
            for (int i = 0; i < strs.Length - 1; i++)
            {
                if ((strs[i] == "") || (strs[i + 1] == "") || (strs[i][0] != strs[i + 1][0])) { return ""; }

                string current = "";
                for (int j = 0; j < strs[i].Length && j < strs[i + 1].Length && (strs[i][j] == strs[i + 1][j]); j++)
                {
                    current += strs[i][j];
                }
                if (current != "" && (i<strs.Length-2))
                {
                    strs[i+1] = current;
                }
                else { result = current; }
            }
            return result;
        }
    }
    
}
