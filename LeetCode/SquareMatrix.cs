using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SquareMatrix
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { -1, 1, -7, -8 };
            List<int> list2 = new List<int> { -10, -8, -5, -2 };
            List<int> list3 = new List<int> { 0, 9, 7, -1 };
            List<int> list4 = new List<int> { 4, 4, -2, 1 };

            List<List<int>> arr = new List<List<int>> {list1, list2, list3, list4 };

            Console.WriteLine(diagonalDifference(arr));

        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int count = 0;
            int diagOne = 0;
            int diagTwo = 0;

            foreach (var item in arr)
            {
                if (count == 0 || count == (arr.Count()-1))
                {
                    if (count == 0)
                    {
                        diagOne += item.First();
                        diagTwo += item.Last();
                    }
                    else
                    {
                        diagOne += item.Last();
                        diagTwo += item.First();
                    }
                }
                else
                {
                    diagOne += item[count];
                    diagTwo += item[item.Count - (count + 1)];
                }
                count++;
            }
            return Math.Abs((diagOne - diagTwo));
        }
    }
}
