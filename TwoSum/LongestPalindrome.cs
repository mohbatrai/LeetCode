using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    static class LongestPalindrome
    {
        public static string LongestPalindromes(string s)
        {
            int start = 0, end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpendFromCneter(s, i, i + 1);
                int len2 = ExpendFromCneter(s, i, i);
                int len = Math.Max(len1, len2);
                if(end-start<len)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }


            }

            return s.Substring(start, end+1);
        }

        public static int ExpendFromCneter(string s, int i, int j)
        {
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {
                i--;
                j++;
            }
            return j - i - 1;
        }
    }
}