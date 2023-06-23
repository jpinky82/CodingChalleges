using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class grid_Challenge
    {
        /*Given a square grid of characters in the range ascii[a-z], rearrange elements of each row alphabetically, ascending. Determine if the columns are also in ascending alphabetical order, top to bottom. Return YES if they are or NO if they are not.

        Example
        grid = ['abc', 'ade', 'efg']

        The grid is illustrated below.

        a b c
        a d e
        e f g
        The rows are already in alphabetical order. The columns a a e, b d f and c e g are also in alphabetical order, so the answer would be YES. Only elements within the same row can be rearranged. They cannot be moved to a different row.

        Function Description

        Complete the gridChallenge function in the editor below.

        gridChallenge has the following parameter(s):

        string grid[n]: an array of strings
        Returns

        string: either YES or NO
        Input Format

        The first line contains , the number of testcases.

        Each of the next  sets of lines are described as follows:
        - The first line contains , the number of rows and columns in the grid.
        - The next  lines contains a string of length 

        Constraints
        1 <= t <= 100
        1 <= n <= 100
        Each string consists of lowercase letters in the range ascii[a-z]

        Output Format

        For each test case, on a separate line print YES if it is possible to rearrange the grid alphabetically ascending in both its rows and columns, or NO otherwise.

        Sample Input

        STDIN   Function
        -----   --------
        1       t = 1
        5       n = 5
        ebacd   grid = ['ebacd', 'fghij', 'olmkn', 'trpqs', 'xywuv']
        fghij
        olmkn
        trpqs
        xywuv
        Sample Output

        YES
        Explanation

        The x grid in the  test case can be reordered to

        abcde
        fghij
        klmno
        pqrst
        uvwxy
        This fulfills the condition since the rows 1, 2, ..., 5 and the columns 1, 2, ..., 5 are all alphabetically sorted.*/

        static void Main(string[] args)
        {
            List<string> grid = new List<string>()
            {
                "eabcd",
                "fghij",
                "olkmn",
                "trpqs",
                "xywuv"
            };

            Console.WriteLine(gridChallenge(grid));

        }

        public static string gridChallenge(List<string> grid)
        {
            int length = grid[0].Length;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < grid.Count; i++)
            {
                char[] characters = grid[i].ToArray();
                Array.Sort(characters);
                grid[i] = new string(characters);
            }

            for (int r = 0; r < grid.Count - 1; r++)
            {
                for (int c = 0; c < length; c++)
                {
                    if (alphabet.IndexOf(grid[r][c]) > alphabet.IndexOf(grid[r + 1][c]))
                    {
                        return "NO";
                    }
                }
            }
            return "YES";
        }
    }


}
