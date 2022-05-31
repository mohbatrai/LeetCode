using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
   static public class Zig_Zag
    {
         public static void pzz(string s,int n)
        {
            if (n == 0)
                return;

            Console.Write(s[s.Length-n]);
            pzz(s,n - 1);
            Console.Write(s[s.Length - n]);
            pzz(s,n - 1);
            Console.Write(s[s.Length - n]);
            pzz(s,n - 1);
        }
    }
}
