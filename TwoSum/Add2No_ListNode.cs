using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
   static class Add2No_ListNode
    {
        static public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode oListNode = new ListNode(0);

            return oListNode;
        }
    }

    
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
      {
           this.val = val;            
           this.next = next;
      }
    }

}
