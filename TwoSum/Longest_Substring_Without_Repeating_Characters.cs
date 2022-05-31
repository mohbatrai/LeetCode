using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace TwoSum
{
    static public class Longest_Substring_Without_Repeating_Characters
    {

        static public int LengthOfLongestSubstring(string str)
        {
            int max = 0, left = 0, right = 0;
            HashSet<char> Set = new HashSet<char>();
            List<string> res = new List<string>();

           while (right < str.Length)
            {
                char c = str[right];
                if (Set.Add(c))
                {
                    if (right - left + 1 > max)
                        max = right - left + 1;
                    right++;
                }
                else
                {                    
                    Set.Remove(str[left]);
                    left++;
                }
                
            }


            return max;

            //int max = 0, start=0,end=0;
            //List<char> Set = new List<char>();
            //List<string> res = new List<string>();

            //char[] ch = str.ToCharArray();
            //while (start<str.Length)
            //{
            //    if (Set.Count == 0)
            //        Set.Add(ch[start]);

            //    char crnt = ch[start];
            //    if (crnt==Set.Last())
            //    {
            //        if ((start - end) + 1 > max)
            //            max = (start - end) + 1;
            //        res.Add(str[start].ToString());
            //        start++;
            //    }
            //    else
            //    {
            //        Set.Remove(ch[end]);
            //        end++;

            //    }

            //}

            //return max;


            //char[] ch = s.ToCharArray().Distinct().ToArray();
            //return ch.Count();

            //List<string> list = new List<string>();
            //char[] arr = s.ToCharArray();
            //for (int i = 0; i < arr.Length; i++)
            //{              
            //    if (list.Count == 0)
            //        list.Add(arr[i].ToString());
            //    else if (!list.Contains(arr[i].ToString()))
            //        list.Add(arr[i].ToString());
            //}
            //return list.Count;

            //int count = 0, max=0, rept=0;

            //HashSet<char> hash_set = new HashSet<char>();
            //while(count<s.Length)
            //{
            //    if(hash_set.Contains(s.ElementAt(count)))
            //    {
            //        hash_set.Add(s.ElementAt(count));
            //        count++;
            //        max = Math.Max(hash_set.Count(), max);
            //    }
            //    else
            //    {
            //        hash_set.Remove(s.ElementAt(rept));
            //        rept++;
            //    }
            //}
            //return max;


            //int n = str.Length;

            //// Result
            //int res = 0;

            //for (int i = 0; i < n; i++)
            //    for (int j = i; j < n; j++)
            //        if (areDistinct(str, i, j))
            //            res = Math.Max(res, j - i + 1);

            //return res;

            //int ans = 0;
            //int i = -1;
            //int j = -1;
            ////Dictionary<string, int> dict = new Dictionary<string, int>();
            //Hashtable dict = new Hashtable();
            //while (true)
            //{
            //    //acqure
            //    while(i<str.Length-1)
            //    {                   
            //        i++;
            //        char ch = str.ElementAt(i);
            //        dict.Add(ch.ToString(), 1);    
            //        int a;
            //        //if (dict.TryGetValue(ch.ToString(), out a))
            //        //{
            //        //    //continue with your logic                    
            //    }
            //}
        }

        public static bool areDistinct(string str,int i, int j)
        {

            // Note : Default values in visited are false
            bool[] visited = new bool[26];

            for (int k = i; k <= j; k++)
            {
                if (visited[str[k] - 'a'] == true)
                    return false;

                visited[str[k] - 'a'] = true;
            }
            return true;
        }

    }

    
}
