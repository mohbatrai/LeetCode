using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
   public class twosum
    {
        public static List<int> Maximunsubarrays(int[] nums, int k)
        {

            List<int> lst = new List<int>();
            int ans = 0;

            if (nums.Length == 0)
                return lst;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < i+k; j++)
                {
                    //sum = nums[i] + nums[j];
                    if (nums[j] > nums[i])
                        ans = nums[j];
                    else if (nums[j] < nums[i])
                        ans = nums[i];
                    else
                        ans = nums[j];
                }
                lst.Add(ans);
            }

            return lst;
        }


        public static int[] TwoSumBouteForce(int[] nums, int target)
        {

            int sum = 0;


            if (nums.Length == 0)
                return new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    sum = nums[i] + nums[j];
                    if (sum == target)
                        return new int[] { i, j };
                }
            }

            return new int[2];
        }


        public static int[] TwoSumTwoPointer(int[] nums, int target)
        {
            Array.Sort(nums);
            int sum = 0,left=0,right=nums.Length-1;
            while (left < nums.Length)
            {
                sum = nums[left] + nums[right];
                if (target < 0)
                {
                    if (sum < target)
                        right--;
                    else if (sum > target)
                        left++;
                    else return new int[] { left, right };
                }
                else
                {
                    if (sum > target)
                        right--;
                    else if (sum < target)
                        left++;
                    else return new int[] { left, right };
                }
            }
            return new int[2];  // Return a default value if no solution is found
        }

        //int[] nums = { 150, 24, 79, 50, 88, 345, 3 };
        public static int[] TwoSumSliding(int[] nums, int target)
        {
            Dictionary<int, int> numToIndex = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numToIndex.ContainsKey(complement))               
                    return new int[] { numToIndex[complement], i };  
                numToIndex[nums[i]] = i;
            }
            return new int[2];  // Return a default value if no solution is found
        }
    }
}
