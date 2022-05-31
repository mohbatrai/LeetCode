using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class FindMedianSortedArray
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0;
            double total = 0;
            List<int> record = new List<int>();
            foreach (int item in nums1)
            {
                record.Add(item);
                total += item;
            }

            foreach (int item in nums2)
            {
                record.Add(item);
                total += item;
            }
            record.Sort();
            if (record.Count % 2 == 0)
            {
                var firstValue = record[(record.Count / 2) - 1];
                var secondValue = record[(record.Count / 2)];
                median = (firstValue + secondValue) / 2.0;
            }
            if (record.Count % 2 == 1)            
                median = record[(record.Count / 2)];
            
            
            return median;
        }
    }
}
