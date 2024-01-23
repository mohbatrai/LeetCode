using System;
using System.Collections.Generic;
using System.Linq;

namespace binarygap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(Solution.AssignTeam(n));
            Console.WriteLine(Solution.AssignTeam(5));
            Console.WriteLine(Solution.AssignTeam(15));


            //Console.WriteLine(Solution.minFiltersNeeded(new int[] { 5, 19, 8, 1 })); // should return 3
            //Console.WriteLine(Solution.minFiltersNeeded(new int[] { 10, 10 })); // should return 2
            //Console.WriteLine(Solution.minFiltersNeeded(new int[] { 3, 0, 5 })); // should return 2


            //int[] pollutionAmounts = { 5, 19, 8, 1 };
            //int minFilters = Solution.minFiltersNeeded(pollutionAmounts);
            //int X = 10, Y = 85, D = 30;
            //Solution.FrogJmp(X, Y, D);

            //int[] A = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            //Solution.OddOccurrencesInArray(A);
            //string[] sentences = {"alice and bob love leetcode", "i think so too", "this is great thanks very much"};
            //Solution.MostWordsFound(sentences);

            //int n = 3, k = 2, row = 0, column = 0;
            //double d=  Solution.KnightProbability(n,k,row,column);
            //Console.WriteLine("Total Moves " + d);

            //Tuple<int, int> currentPosition = new Tuple<int, int>(3, 4); // Example current position of the knight
            //List<Tuple<int, int>> possibleMoves =Solution.GetPossibleKnightMoves(currentPosition);

            //foreach (var move in possibleMoves)
            //{
            //    Console.WriteLine($"Possible move: Row {move.Item1}, Column {move.Item2}");
            //}

            //int c = Solution.fabonicc(8);
            //string P = "abc", Q = "bcd";
            //int asn = Solution.distinctLettersMinima(P,Q);
            //int[] A = { 3, 8, 9, 7, 6 };
            //int k = 3;

            //int[] asn= Solution.ArrayShiffeted(A, k);
            //int N = 15;
            //int a = Solution.Gap(N);
            //int asn= Solution.FindBinaryGap(N);
            //   Console.WriteLine("Hello World!"+ c);

            //string binary = System.Convert.ToString(N, 2);
            //Console.WriteLine("Hello World!" + binary);

            Console.ReadLine();
        }
    }

    public static class Solution
    {

        /// <summary>
        /// If number is multiple of n=3 return "Team Three"
        /// If number is multiple of 3=5 return "Team Five"
        /// If number is multiple of both return "Dream Team"
        /// If number is not multiple of either 3 or 5 return "-1"
        /// output ["-1","",""]
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static string AssignTeam(int n)
        {
            
            string ans = "";
            //for (int i = n-1; i>=0; i--)
            for (int i = 1; i <=n; i++)
            {           
           
            if (i % 3 == 0)                  
                    ans= ans+  "Team Three";
           else if (i % 5 == 0)
                    ans = ans + "Team Five";
           else if (i % 3 == 0 && n % 5 == 0)
                    ans = ans + "Dream Team";
            else
                    ans = ans +  "-1";
                if (ans.Length > 0)
                    ans = ans + ",";
            }

            ans = ans.Remove(ans.Length-1);
            return ans;
        }


            /// <summary>
            /// An industrial company has N factories each producing some pollution every month . the company has decided to reduce its total fume emission by equipping some of the factories with one or more filters.
            /// Every such filter reduces the pollution of a factory by half.When is second or subsequent filter is applied it again reduced by half the remaining pollution 
            /// emitted After fitting the existing filter for example affected factory that initially produced 6 unit of pollution will generate 3 unit with one filter, 1.5 unit with 2 filters and 0.75 unit 3 filters
            /// You are given an array of N Integers describing the amount of pollutions produced by the factory.your task is to find minimum number of filter needed to decrease the sum of pollution by at least half
            /// Write a function which, given and array of integers A of length N, returns the minimum number of filter needed to reduce the total pollution by at least half 
            /// Given A =[5, 19, 8, 1], yout function should return 3.the initial total pollution is 5 + 19 + 8 + 1 = 33 .we installed 2 filters at the factory producing 19 unit and 
            /// one filter at the factory producing 8 unit.THen the total number pollution will be 5 + ((19/2)/2) + (8 / 2) + 1 = 5 + 4.75 + 4 + 1 =14.75 which is less than 33/2 = 16.5 vah bhi hai achieve the goal
            /// </summary>
            /// <param name="A"></param>
            /// <returns></returns>
            public static int minFiltersNeeded(int[] A)
        {

            #region "Broute force"

            //// Calculate the total pollution
            //double totalfilters = A.Sum();
            //double targetfilters = totalfilters / 2.0;

            //int roud = 0;
            //while (totalfilters > targetfilters)
            //{
            //    int maxNum = 0;
            //    int index = -1;
            //    for (int i = 0; i < A.Length; i++)
            //    {
            //        if (A[i] > maxNum)
            //        {
            //            maxNum = A[i];
            //            index = i;
            //        }
            //    }

            //    A[index] = (maxNum / 2);
            //    totalfilters = totalfilters - (maxNum / 2.0);
            //    roud++;
            //}
            //return roud;
            #endregion


            #region "Sliding "

            double totalfilters = A.Sum();
            double targetfilters = totalfilters / 2.0;

            List<int> sortedFilters = A.ToList();
            sortedFilters.Sort();
            int roud = 0;
            while (totalfilters > targetfilters)
            {
                int maxNum = sortedFilters.Last();
                sortedFilters.Remove(maxNum);
                                             
                totalfilters = totalfilters - (maxNum / 2);
                sortedFilters.Add(maxNum / 2);
                sortedFilters.Sort();
                roud++;
            }
            return roud;


            #endregion
        }




        /// <summary>
        /// A small frog wants to get to the other side of the road. The frog is currently located at position X and wants to 
        /// get to a position greater than or equal to Y. The small frog always jumps a fixed distance, D.
        /// Count the minimal number of jumps that the small frog must perform to reach its target.Write a function:
        /// class Solution { public int solution(int X, int Y, int D); }
        /// that, given three integers X, Y and D, returns the minimal number of jumps from position X to a position equal to or greater than Y.
        /// For example, given:  X = 10  Y = 85  D = 30
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="D"></param>
        /// <returns></returns>
        public static int FrogJmp(int X, int Y, int D)
            {
            int distance = Y - X;           
            int jumps = distance / D;           
            if (distance % D != 0)           
                jumps++;  
            return jumps;

            //int i = 1;
            //while ((X + D) <= Y)
            //{
            //    X = X + D;
            //    i++;
            //}

            //return i;
            }


        /// <summary>
        /// A non-empty array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be 
        /// paired with another element that has the same value, except for one element that is left unpaired. For example, in array A such that:
        //  A[0] = 9  A[1] = 3  A[2] = 9
        //  A[3] = 3  A[4] = 9  A[5] = 7
        //  A[6] = 9
        //the elements at indexes 0 and 2 have value 9,
        //the elements at indexes 1 and 3 have value 3,
        //the elements at indexes 4 and 6 have value 9,
        //the element at index 5 has value 7 and is unpaired.
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>

        public static int OddOccurrencesInArray(int[] A)
        {
            return A.Aggregate(0, (a, b) => a ^ b); // 100 % correct
        }
        public static int OddOccurrencesInArray2(int[] A)
        {
         Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i<A.Length; i++)
            {
                if (values.ContainsKey(A[i]))
                    values[A[i]]++;
                else
                    values[A[i]] = 1;
            }
            //values.Count(e => e.Value % 2 == 1);
             return values.Count(e => e.Value % 2 == 1); //values.Where(e => e.Value % 2 == 1).Count(k => k.Key);
        }
        /// <summary>
        ///  Longest Substring Without Repeating Characters
        ///  Example 1:

        //        Input: s = "abcabcbb"
        //Output: 3
        //Explanation: The answer is "abc", with the length of 3.
        //Example 2:

        //Input: s = "bbbbb"
        //Output: 1
        //Explanation: The answer is "b", with the length of 1.
        //Example 3:

        //Input: s = "pwwkew"
        //Output: 3
        //Explanation: The answer is "wke", with the length of 3.
        //Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
        //        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> val = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (char.IsLetter(c))
                {
                    if (val.ContainsKey(c))
                        val[c]++;
                    else
                        val[c] = 1;
                }
            }

            return val.Count(x => x.Value == 1);
        }

        /// <summary>
        /// A sentence is a list of words that are separated by a single space with no leading or trailing spaces.
        /// You are given an array of strings sentences, where each sentences[i] represents a single sentence.
        /// Return the maximum number of words that appear in a single sentence.
        /// </summary>
        /// <param name="sentences"></param>
        /// <returns></returns>
        public static int MostWordsFound(string[] sentences)
        {
            //string[] str = sentences.ToArray();
            //string[] count ;
            int max = 0;

            //if (str.Length > 0)
            //{
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        count = str[i].Split(' ');
            //        if (max == 0) max = count.Length;
            //        else if(count.Length > max) max = count.Length;
            //    }
            //}
            //return max;

            foreach (string item in sentences)
            {
                int current = item.Split(' ').Length;
                if (current > max) max = current;
            }
            return max;
        }


            public static double KnightProbability(int n, int k, int row, int column)
        {
            int[][] directions = new int[][] {
            new int[] { 2, 1 },
            new int[] { 1, 2 },
            new int[] { -1, 2 },
            new int[] { -2, 1 },
            new int[] { -2, -1 },
            new int[] { -1, -2 },
            new int[] { 1, -2 },
            new int[] { 2, -1 } };

            double[,,] dp = new double[n, n, k + 1];
            dp[row, column, 0] = 1;

            for (int s = 1; s <= k; s++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        foreach (var dir in directions)
                        {
                            int prevRow = i + dir[0];
                            int prevCol = j + dir[1];
                            if (prevRow >= 0 && prevRow < n && prevCol >= 0 && prevCol < n)                            
                                dp[i, j, s] += dp[prevRow, prevCol, s - 1] / 8;                            
                        }
                    }
                }
            }

            double totalProbability = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    totalProbability += dp[i, j, k];                
            }

            return totalProbability;
        }

        public static List<Tuple<int, int>> GetPossibleKnightMoves(Tuple<int, int> currentPosition)
        {
            List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();

            // Possible relative knight moves
            int[] rowOffsets = { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] colOffsets = { 1, 2, 2, 1, -1, -2, -2, -1 };
            for (int i = 0; i < 8; i++)
            {
                int row = currentPosition.Item1 + rowOffsets[i];
                int col = currentPosition.Item2 + colOffsets[i];

                if (row >= 1 && row <= 8 && col >= 1 && col <= 8)
                    possibleMoves.Add(new Tuple<int, int>(row, col));
            }
            return possibleMoves;

        }

        public static int fabonicc(int a)
        {
            //if (a == 0 || a == 1)
            //    return a;
            //else
            // {
            int x=0, y=1, z=0;
            Console.Write("{0} {1} ",x, y);
            for (int i = 0; i < a; i++)
                {
                z = x + y;
                Console.Write("{0} ",z);
                x = y;
                y = z;
            }
                //int b = fabonicc(a - 1) + fabonicc(a - 2);
                //Console.Write(b + " ");
                return z;

            //}
                 
          
        }

        static public int distinctLettersMinima(string P, string Q)
        {
            HashSet<char> distinctChars = new HashSet<char>();

            for (int i = 0; i < P.Length; i++)
            {
                distinctChars.Add(P[i]);
                distinctChars.Add(Q[i]);
            }

            return distinctChars.Count;
        }

        static public int[] CyclicRotation(int[] A, int K)
        {
            int[] temp = new int[A.Length];  
            for (int i = 0; i < A.Length; i++)
                 temp[(i + K) % A.Length] = A[i];  
            return temp;
        }
        public static int Gap(int N)
        {

            int ans = 0, reminder = 0;           
            List<int> max = new List<int>();

            if (N == 0) return ans;
            reminder = N;
            while (reminder >= 1)
            {
                if (reminder % 2 == 0)
                {
                    ans = ans + 1;
                    reminder = reminder / 2;
                }
                else
                {
                    if (reminder == 1)
                    {
                        if(max.Count>0)
                        max.Add(ans);
                    }
                    else max.Add(ans);
                    reminder = reminder / 2;
                    ans = 0;
                  }
            }

            if (max.Count > 0)
                ans =max.Max();
            return ans;

        }
        public static int BinaryGap(int N)
        {
            string binaryRepresentation = Convert.ToString(N, 2);
            int maxGap = 0;
            int currentGap = 0;        

            foreach (char bit in binaryRepresentation)
            {
                if (bit == '1')
                {
                    maxGap = currentGap;
                    currentGap = 0;
                }
                else if (bit == '0')
                    currentGap++;
            }
            return maxGap;
        }

    }
}
