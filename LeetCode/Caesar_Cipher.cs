using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Caesar_Cipher
    {

        static void Main(string[] args)
        {

            string s = "www.abc.xy";
            int k = 87;

            Console.WriteLine(caesarCipher(s, k));

        }

        public static string caesarCipher(string s, int k)
        {
            if (k > 26) { k = k % 26; }
            string original = "abcdefghijklmnopqrstuvwxyz";
            string rotated = original + original.Substring(0, k);
            rotated = rotated.Remove(0, k);

            string encrypted = "";
            foreach (char item in s)
            {
                if (char.IsLetter(item))
                {
                    char newChar = rotated[original.IndexOf(item.ToString()
                    .ToLower())];

                    if (char.IsUpper(item)) 
                    {
                        encrypted = encrypted + newChar.ToString().ToUpper(); ;
                    }
                    else 
                    {
                        encrypted = encrypted + newChar;
                    }
                }
                else
                {
                    encrypted = encrypted + item;
                }
            }
            return encrypted;
        }
    }
}
