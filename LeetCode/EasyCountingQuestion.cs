using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    
    internal class EasyCountingQuestion
    {
        static void countUp(int start)
        {
            // Complete the countUp function below.
            string result = $"{start}";
            for (int i = 0; i < 10; i++)
            {
                if (i != 9)
                {
                    result = $"{result} then {start += 1}";
                }
                else
                {
                    result = $"{result} {start += 1}";
                }
            }
            Console.WriteLine(result);
        }
    }


    

}
