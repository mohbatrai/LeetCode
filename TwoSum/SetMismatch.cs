using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    static class SetMismatch
    {
        public static int[] MisMatch(int[] nums)
        {
            int[] Output = { 0, 0 };

            if (nums.Length == 0)
                return Output;

            for (int x = 0; x < nums.Length; x++)
            {
                if (nums.Contains(x+1) == false)
                    Output[1] = x+1;

                for (int y = 0; y < nums.Length; y++)
                {
                    if (x == y)
                        continue;

                    if ((x != y) && (nums[x] == nums[y]))
                        Output[0] = nums[x];
                }
            }


                return Output;

        }
    }
}
