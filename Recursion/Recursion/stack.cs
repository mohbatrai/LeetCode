using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    static class stack
    {

        public static int[] GreaterRight(int[] list)
        {
            Stack<int> s = new Stack<int>();
            int[] ans = new int[list.Length];

            //for (int i = list.Length - 1; i >= 0; i--)
            //{
            //    while (s.Count > 0 && s.Peek() <= list[i])
            //        s.Pop();

            //    ans[i] = (s.Count == 0) ? -1 : s.Peek();
            //    s.Push(list[i]);
            //}

            for (int i = list.Length - 1; i >= 0; i--)
            {
                while (s.Count > 0 && s.Peek() <= list[i])
                    s.Pop();

                ans[i] = (s.Count == 0) ? -1 : s.Peek();
                s.Push(list[i]);
            }



            return ans;
        }

        public static int[] GreaterRight1(int[] list)
        {
            Stack<int> s = new Stack<int>();
            int[] ans = new int[list.Length];

            for (int i = list.Length-1; i >= 0; i--)
            {
                if (s.Count == 0)
                    ans[i] = -1;
                else if (s.Count > 0 && s.Peek() > list[i])
                    ans[i] = s.Peek();
                else if (s.Count > 0 && s.Peek() <= list[i])
                {
                    while (s.Count > 0 && s.Peek() <= list[i])
                        s.Pop();
                    if(s.Count==0)
                        ans[i] = -1;
                    else ans[i] = s.Peek();
                }

                s.Push(list[i]);
            }
            return ans;
        }

        public static Stack GreaterRight11(int[] list)
        {
            Stack stk = new Stack();
            int lastNum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (stk.Count == 0)
                {
                    stk.Push(list[i]);
                    lastNum = list[i];
                }
                else if (list[i] > lastNum)
                {
                    stk.Pop();
                    stk.Push(list[i]);
                    lastNum = list[i];
                }
            }
            return stk;
        }



        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            //Stack stk = new Stack();
            int[] stks= new int[nums1.Length] ;
            int lastNum = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                bool isadd = false;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums2[j] == nums1[i])
                    {
                        isadd = true;
                        if (nums2.Length - 1 == j)
                        {
                            stks[i] = -1;
                            continue;
                        }
                        lastNum = nums2[j + 1];
                        if (lastNum > nums1[i])
                        {
                            stks[i] = lastNum;
                            isadd = false;
                        }
                        else if (nums1[i] < lastNum)
                        {
                            stks[i] = -1;
                            isadd = false;
                        }
                    }
                    else if (isadd)
                    {                      
                        if (nums2.Length - 1 == j)
                        {
                            stks[i] = -1;
                            continue;
                        }
                        lastNum = nums2[j + 1];
                        if (lastNum > nums1[i])
                        {
                            stks[i] = lastNum;
                            isadd = false;
                        }
                        else if (nums1[i] < lastNum)
                        {
                            stks[i] = -1;
                            isadd = false;
                        }
                    }
                }
            }
            return stks;
        }
    }
}
