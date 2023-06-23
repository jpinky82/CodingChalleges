using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FizzBuzzprob
    {
        static void Main(string[] args)
        {

            /*
             * Given an integer n, return a string array answer (1-indexed) where:

            answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
            answer[i] == "Fizz" if i is divisible by 3.
            answer[i] == "Buzz" if i is divisible by 5.
            answer[i] == i (as a string) if none of the above conditions are true.
 

            Example 1:

            Input: n = 3
            Output: ["1","2","Fizz"]
            Example 2:

            Input: n = 5
            Output: ["1","2","Fizz","4","Buzz"]
            Example 3:

            Input: n = 15
            Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
 

            Constraints:

            1 <= n <= 104*/

            IList<string> getResult = FizzBuzz(15);

            foreach (var item in getResult)
            {
                Console.WriteLine(item);
            }



        }
        public static IList<string> FizzBuzz(int n)
        {
            int current = 1;
            IList<string> result = new List<string>();

            do
            {
                if (current % 3 == 0 && current % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (current % 5 == 0 && current % 3 != 0)
                {
                    result.Add("Buzz");
                }
                else if (current % 3 == 0 && current % 5 != 0)
                {
                    result.Add("Fizz");
                }
                else
                {

                    result.Add(Convert.ToString(current));
                }
                current++;
                n--;

            } while (n > 0);

            return result;

            //LeetCode Solution
            //IList<string> answer = new List<string>();

            //for (int i = 1; i <= n; i++)
            //{
            //    bool divisibleBy3 = i % 3 == 0;
            //    bool divisibleBy5 = i % 5 == 0;

            //    string currStr = "";

            //    if (divisibleBy3)
            //    {
            //        currStr += "Fizz";
            //    }

            //    if (divisibleBy5)
            //    {
            //        currStr += "Buzz";
            //    }

            //    if (currStr.Length == 0)
            //    {
            //        currStr += Convert.ToString(i);
            //    }

            //    answer.Add(currStr);
            //}
            //return answer;
        }
    }
}
