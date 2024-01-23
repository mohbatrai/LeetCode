using System;
using System.Collections.Generic;
using System.Linq;

namespace longestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> val = new Dictionary<char, int>();

            string s = "pwwkew";



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

                  int a = val.Count(x => x.Value == 1);
            Console.WriteLine("Count is " + a);
            Console.WriteLine("Count is " + val.Count);
            Console.ReadLine();
        
        }
    }
}
