using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RunningSumProb
    {
        static void Main(string[] args)
        {

            //Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

            //Return the running sum of nums.




            //Example 1:

            //Input: nums = [1, 2, 3, 4]
            //Output: [1,3,6,10]
            //Explanation: Running sum is obtained as follows: [1, 1 + 2, 1 + 2 + 3, 1 + 2 + 3 + 4].
            //Example 2:

            //Input: nums = [1, 1, 1, 1, 1]
            //Output: [1,2,3,4,5]
            //Explanation: Running sum is obtained as follows: [1, 1 + 1, 1 + 1 + 1, 1 + 1 + 1 + 1, 1 + 1 + 1 + 1 + 1].
            //Example 3:

            //Input: nums = [3, 1, 2, 10, 1]
            //Output: [3,4,6,16,17]

            int[] nums = { 1, 2, 3, 4 };

            int [] results = RunningSum(nums);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

        }

        public static int[] RunningSum(int[] nums)
        {
            int[] solution = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                solution[i] = sum;
            }
            return solution;

            //Solution from Leet Code

            //int[] solution = new int[nums.Length];
            //solution[0] = nums[0];
            //for (int i = 1; i< nums.Length; i++)
            //{
            //    solution[i] = nums[i] + solution[i - 1];
            //}
            //return solution;
        }
    }
}
