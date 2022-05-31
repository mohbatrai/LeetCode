using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public static class validParenthesis
    {
        public static bool IsValid(string s)
        {
            bool isTrue = false;
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (s.Length == i + 1)
                    break;

                if (ch[i] == ch[i + 1])
                    isTrue = true;
            }
            return isTrue;

        }

    }
}
