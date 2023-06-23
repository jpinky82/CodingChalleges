using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Lottery_Sum
    {
        /*
            Given a list of lottery numbers and a winning number (k), print to the console any permutation of 3 numbers from the list that add up to k.

             - No number can be duplicated in their list of 3 and no list of 3 can be duplicated in the return.

            Example:
            [1, 2, 3], k=6
             - prints [1, 2, 3]
            
            Example 2:
            [5, 2, 8, -4, 0, 6, 3, 1], k=9
             - prints [5, 8, -4], [5, 3, 1], [8, 0, 1], [2, 6, 1], [0, 6, 3]
         */

        static void Main(string[] args)
        {

            List<int> numbers = new List<int>()
            {
                5, 2, 8, -4, 0, 6, 3, 1, 2, 8, 6
            };
            int k = 9;

            PrintNums(numbers, k);

        }

        public static void PrintNums(List<int> numbers, int k) 
        {
            List<List<int>> result = new();
            //string result = "";

            for(int h = 0; h < numbers.Count; h++)
            {
                for (int i = h+1; i< numbers.Count; i++)
                {
                    if(numbers[h] != numbers[i])
                    {
                        for (int j = i + 1; j < numbers.Count; j++)
                        {
                            if( numbers[j] != numbers[h] && numbers[j] != numbers[i])
                            {
                                if (numbers[h] + numbers[i] + numbers[j] == k)
                                {
                                    if(result.Count > 0)
                                    {
                                        List<int> addNew = new List<int>()
                                        {
                                            numbers[h],
                                            numbers[i],
                                            numbers[j]
                                        };
                                        addNew.Sort();

                                        bool duplicate = false;
                                        for (int l = 0; l< result.Count; l++)
                                        {
                                            if (addNew[0] == result[l][0] && addNew[1] == result[l][1] && addNew[2] == result[l][2])
                                            {
                                                duplicate = true;
                                            }
                                        }
                                        if (!duplicate) { result.Add(addNew); }
                                    }
                                    else
                                    {
                                        List<int> addList = new List<int>()
                                        {
                                            numbers[h],
                                            numbers[i],
                                            numbers[j]
                                        };
                                        addList.Sort();
                                        result.Add(addList);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"[{result[i][0]}, {result[i][1]}, {result[i][2]}]");
            }
        }
    }
}
