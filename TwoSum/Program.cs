using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] Output = { 0, 0 };

            if (nums.Length == 0)
                return Output;

            for (int x = 0; x < nums.Length; x++)
            {
                for (int y = 0; y < nums.Length; y++)
                {
                    if (x == y)
                        continue;

                    int a = nums[x];
                    int tarRel = nums[x] + nums[y];
                    if (tarRel.Equals(target))
                    {
                        Output[0] = x;
                        Output[1] = y;
                        return Output;
                    }
                }
            }

            return Output;
        }
        static void Main(string[] args)

        {
           // int[] nums = { 10, 20, 30 };
            
           // int target = 15;
            //Console.WriteLine(TwoSum(nums, target));
            //bool a=  validParenthesis.IsValid("()");
            // int[] res = SetMismatch.MisMatch(nums);

            //Console.WriteLine(Two_Sum_Less_Than_K.TwoSumLessthanK(nums, target));

            //string s = "pwwkew";
            //Longest_Substring_Without_Repeating_Characters.LengthOfLongestSubstring(s);

            //int[] nums1 = { 1, 2 }, nums2 = { 3,4,5 };
            //FindMedianSortedArray.FindMedianSortedArrays(nums1, nums2);

          //  string s = "baab";//"babad"; //baab
          //  LongestPalindrome.LongestPalindromes(s);



            //int[][] cards = new int[][]{
            //                           new int[] {  5, 7, 3, 9, 4, 8, 3, 1 },
            //                           new int[] { 1, 2, 2, 4, 4, 1},
            //                           new int[] { 1, 2, 3 }
            //                           };
            //cardWinning.win(cards);

            Zig_Zag.pzz("PAYPALISHIRING", 3);
            Console.ReadKey();
        }
    }
}
