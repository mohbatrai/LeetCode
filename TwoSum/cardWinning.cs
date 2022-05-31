using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class cardWinning
    {
      

        public static int win(int[][] cards)
        {
            int res = -1;
            List<int> num = new List<int>();
            int[] arr1=null, arr2=null, arr3=null, arr4=null;

            if (cards.Length==1)
            arr1 = cards[0];
            else if (cards.Length == 2)
            {
                arr1 = cards[0];
                arr2 = cards[1];
            }
            else if (cards.Length == 3)
                        {
                arr1 = cards[0];
                arr2 = cards[1];
                arr3 = cards[2];
            }
            else if (cards.Length == 4)
            {
                arr1 = cards[0];
                arr2 = cards[1];
                arr3 = cards[2];
                arr4 = cards[3];
            }
           

            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = 0; j < cards[i].Length; j++)
                {
                    if (i == j)
                        continue;
                    
                    if (cards[i][j] == cards[i][j])
                    {
                        num.Add(cards[i][j]);

                    }
                }
            }

            return res;
        }
    }
}
