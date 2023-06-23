using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Flipping_The_Matrix
    {
        /*
         Sean invented a game involving a 2n x 2n matrix where each cell of the matrix contains an integer.
         He can reverse any of its rows or columns any number of times. The goal of the game is to maximize the sum
         of the elements in the n x n submatrix located in the upper left quadrant of the matrix.
         
        Given the initial Configurations for q matrices, help Sean reverse the rows and columns of each matrix in the best
        possible way so that the sum of the elements in the matrix's upper-left quatrant is maximal.
        
        EXAMPLE
        matrix = [[1,2], [3,4]]
            
            1 2
            3 4

        It is 2 x 2 and we want to maximize the top left quadrant, a 1 x 1 matrix. Reverse Row 1:
            
            1 2
            4 3

        And now reverse column 0:

            4 2
            1 3
        The Maximal sum is 4.

        FUNCTION DESCRIPTION
        Complete the flippingMatrix function in the editor below.
        flippingMatrix has the following parameters: int matrix[2n][2n] : a 2-dimensional array of integers

        RETURNS 
        int: the maximum sum possible

        INPUT FORMAT
        The first line contains an integer q, the number of queries.
        The next q sets of lines are in the following format: 
        
         - the first line of each query contains an integer, n.
         - Each of the next 2n lines contains 2n space-seperated integers matrix [i][j] in row i of the matrix.

        CONSTRAINTS
         - 1 <= q <= 16
         - 1 <= n <= 128
         - 0 <= matrix [i][j] <= 4096, where 0 <= i, j<2n.

        SAMPLE INPUT

        STDIN       FUNCTION
        1           q = 1
        2           n = 2
        matrix [[112, 42, 83, 119], [56, 125, 56, 49], [15, 78, 101, 43], [62, 98, 114, 108]]

        SAMPLE OUTPUT
        414

        EXPLANATION
        Start out with the following 2n x 2n matrix:
                     __              __
                    |                  |
                    |112   42   83  119|  
                    | 56  125   56   49|
        MATRIX =    | 15   78  101   43|
                    | 62   98  114  108|
                    |__              __|

        Perform the following operations to maximize the sum of n x n submatrix in the upper-left quadrant:
            2. Reseve column 2 ( [83,56,101,114]-> [114,101,56,83], resulting in the matrix: 
                     __              __
                    |                  |
                    |119  114   42  112|  
                    | 56  125  101   49|
        MATRIX =    | 15   78   56   43|
                    | 62   98   83  108|
                    |__              __|

        The sum of values in the n x n submatrix in the upper-left quadrant is
        119 + 114 + 56 + 125  = 414.

        -------------------------------------
        These Instructions are very confusing

         */


        static void Main(string[] args)
        {

        }

        /*
         * Complete the 'flippingMatrix' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
         */

        public static int flippingMatrix(List<List<int>> matrix)
        {
            int queryLength = matrix[0].Count() - 1;
            int halfQueryLength = (matrix[0].Count() / 2) - 1;
            int maxSum = 0;
            for (int row = 0; row <= halfQueryLength; row++)
            {
                for (int col = 0; col <= halfQueryLength; col++)
                {
                    var counter = new List<int>()
                    {
                        matrix[row][col],
                        matrix[row][queryLength - col],
                        matrix[queryLength - row][col],
                        matrix[queryLength - row][queryLength - col],
                    };
                    maxSum += biggerNumber(counter);
                }
            }
            return maxSum;
        }

        public static int biggerNumber(List<int> numberList)
        {
            int bigger = 0;
            foreach (var num in numberList)
            {
                bigger = Math.Max(bigger, num);
            }
            return bigger;
        }
    }
}
