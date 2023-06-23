using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Valid_Parentheses
    {
        static void Main(string[] args)
        {
            /*
            Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

            An input string is valid if:

            Open brackets must be closed by the same type of brackets.
            Open brackets must be closed in the correct order.
            Every close bracket has a corresponding open bracket of the same type.
 

            Example 1:

            Input: s = "()"
            Output: true
            Example 2:

            Input: s = "()[]{}"
            Output: true
            Example 3:

            Input: s = "(]"
            Output: false

            Input: s = "([)]"
            Output: false
 

            Constraints:

            1 <= s.length <= 104
            s consists of parentheses only '()[]{}'.
             */

            string s = "())(";
            Console.WriteLine(IsValid(s));
        }
        public static bool IsValid(string s)
        {
            List<char> open = new List<char> { };

            

            foreach (var item in s)
            {
                if (open.Count == 0 && (item == ')' || item == '}' || item == ']'))
                {
                    return false;
                }
                switch (item)
                {
                    case '(':
                    case '[':
                    case '{':
                        open.Add(item);
                        break;
                    case ')':
                        if (open[open.Count - 1] != '(' || open.Count == 0)
                        {
                            return false;
                        }
                        open.RemoveAt(open.Count - 1);
                        break;

                    case ']':
                        if (open[open.Count - 1] != '[' || open.Count == 0)
                        {
                            return false;
                        }
                        open.RemoveAt(open.Count - 1);
                        break;

                    case '}':
                        if (open[open.Count - 1] != '{' || open.Count == 0)
                        {
                            return false;
                        }
                        open.RemoveAt(open.Count - 1);
                        break;

                    default:
                        return false;
                }
            }
            if (open.Count == 0)
            {
                return true;
            }
            return false;
        }
            

    }
}
