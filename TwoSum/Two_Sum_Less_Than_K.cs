using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    static class Two_Sum_Less_Than_K
    {
        public static int TwoSumLessthanK(int[] nums, int target)
        {
            int output = 0;
            if (nums.Length == 0)
                return output;
            int maxNo = 0;
            for (int x = 0; x < nums.Length; x++)
            {
                for (int y = 0; y < nums.Length; y++)
                {
                    if (x == y)
                        continue;

                    int a = nums[x] + nums[y];
                    if (a > maxNo && a <= target)
                    {
                        maxNo = a;
                        output = maxNo;
                    }
                }
            }
            if (output == 0)
                output = -1;
            return output;
        }
    }



   
}
