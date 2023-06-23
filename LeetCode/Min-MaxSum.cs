using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Min_MaxSum
    {
        static void Main(string[] args)
        {

            #region Notes

            /*Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

            Example

            The minimum sum is  and the maximum sum is . The function prints

            16 24
            Function Description

            Complete the miniMaxSum function in the editor below.

            miniMaxSum has the following parameter(s):

            arr: an array of  integers
            Print

            Print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.

            Input Format

            A single line of five space-separated integers.

            Constraints


            Output Format

            Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)

            Sample Input

            1 2 3 4 5
            Sample Output

            10 14
            Explanation

            The numbers are , , , , and . Calculate the following sums using four of the five integers:

            Sum everything except , the sum is .
            Sum everything except , the sum is .
            Sum everything except , the sum is .
            Sum everything except , the sum is .
            Sum everything except , the sum is .
            Hints: Beware of integer overflow! Use 64-bit Integer.*/
            #endregion

            List<int> nums = new List<int>
            {
            256741038,
            623958417,
            467905213,
            714532089,
            938071625
            };

            minmaxSolution.miniMaxSum(nums);
        }

    }

    public class minmaxSolution
    {
        public static void miniMaxSum(List<int> arr)
        {
            long min = 0;
            long max = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (i != arr.IndexOf(arr.Min()))
                {
                    max += arr[i];
                }
                if (i != arr.IndexOf(arr.Max()))
                {
                    min += arr[i];
                }
            }

            Console.WriteLine($"{min} {max}");

            //Below is an older version.

            //long min = 0;
            //long max = 0;
            //long total = 0;
            //long temp = 0;
            //foreach (var item in arr)
            //{
            //    total += item;

            //}
            //min = total;
            //for (int i = 0; i < arr.Count(); i++)
            //{
            //    temp = (total - arr[i]);


            //    if (temp < min)
            //    {
            //        min = temp;
            //    }
            //    if (temp > max)
            //    {
            //        max = temp;
            //    }
            //}

            //Console.WriteLine($"{min} {max}");
        }
    }

}
