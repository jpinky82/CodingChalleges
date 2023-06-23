using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace LeetCode
{
    internal class TwoSumprop
    {
        static void Main(string[] args)
        {
            /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

            You may assume that each input would have exactly one solution, and you may not use the same element twice.

            You can return the answer in any order.

 

            Example 1:

            Input: nums = [2,7,11,15], target = 9
            Output: [0,1]
            Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            Example 2:

            Input: nums = [3,2,4], target = 6
            Output: [1,2]
            Example 3:

            Input: nums = [3,3], target = 6
            Output: [0,1]*/


            //    int target = 26;

            //    TwoSums(numbers, target);


            int[] numbers = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSum(numbers, target);

            Console.WriteLine($"[{result[0]}, {result[1]}]");


        }

        public static int[] TwoSum(int[] nums, int target)
        {
                
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = (i+1); k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == target)
                    {
                        int[] result = { i, k };
                        return result;
                    }

                }
            }
            return null;
        }
    }
}