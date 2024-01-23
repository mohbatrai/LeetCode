using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {

          //  int[] nums1 = { 4, 1, 2 }, nums2 = { 1, 3, 4, 2 };
          // // int[] nums1 = { 1, 3, 5, 2, 4 }, nums2 = { 6, 5, 4, 3, 2, 1, 7 };
          ////  Stack stk = stack.NextGreaterElement(nums1, nums2);
          //  int[] stk = stack.NextGreaterElement(nums1, nums2);
          //  Console.Write("Power ! " + stk.Length);


            int[] nums = { 1,3,2,4 };
            int[] stk = stack.GreaterRight(nums);
            Console.Write("Power ! " + stk.Length);


            //int[] nums = { 550, 24, 79, 50, 88, 345, 3 };
            //Stack stk = stack.GreaterRight(nums);
            //Console.Write("Power ! " + stk.Count);
            //int[] nums = { 1, 3, -1, -3,5,3,6,7 };
            //int target = 3;
            //List<int> ans = twosum.Maximunsubarrays(nums, target);
            //Console.WriteLine(ans);

            //factriol Call
            //Console.WriteLine("Recursion! " + Factorial(5));          

            // Console.WriteLine("Fibonacci ! " + Fibonacci(7));
            //Fibonaci(0, 1, 1, 8);

            ////it give you nth Fibonacci Number or last no of series
            //for (int i = 0; i < 8; i++)           
            //    Console.Write(FibonaciNth(i)+" "); // without loop it give you nth no or /last no of series


            // Console.Write("Power ! " + Power(2, -2147483648));

            //int[] nums = { -1, -2, -3, -4, -5 };
            //int target = -8;

            //int[] nums = { 150, 24, 79, 50, 88, 345, 3 };
            //int target = 200;
            //int[] ans = twosum.TwoSumSliding(nums, target);
            //Console.WriteLine(ans.Select(x => nums[x]).Sum());

            //int[,] nums = { { 2, 7, 11, 15 }, {4,5,6,7 } };
            //int[,] index = { { 1},{3 } };
            //Console.WriteLine(Enumerable.Range(0,nums.GetLength(0)).Sum(x=>nums[x,index[x,0]]));

            Console.ReadLine();

           
        }



        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1;




            if (n < 0)
            {
                x = 1 / x;
                n = -n;
            }

            double halfPower = Power(x, n / 2);
            double result = halfPower * halfPower;

            if (n % 2 == 1)
                result *= x;

            return result;
        }


        /// <summary>
        /// Factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Factorial(int n)
        {
            if (n == 0 || n == 1 || n == 2)
                return n;
            else                     
                return n * Factorial(n - 1);            
        }
      
        

        public static string Fibonacci(int n)
        {           
            int ans, firstNo=0,secondNo=1;
            string str = firstNo+" "+secondNo;
            for (int i = 0; i < n; i++)
            {                           
                ans = firstNo + secondNo;
                firstNo = secondNo;
                secondNo = ans;
                    str = str + " " + ans.ToString();               
            }
            return str;

        }


        public static void Fibonaci(int firstNo,int SecondNo,int counter, int n)
        {
            if (counter <= n)
            {
                Console.Write(" "+firstNo);
                Fibonaci(SecondNo, firstNo + SecondNo, counter + 1, n);
            } 
        }
        /// <summary>
        /// Fibonacci in Recursive way
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibonaciNth( int n)
        {
            
            if (n == 0 || n == 1)
                return n;
            else                
                return FibonaciNth(n-1)+ FibonaciNth(n-2);
            
        }
    }
}
