using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;

namespace Goh_Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate sorted lists for int
            SortedList sl1 = new SortedList("slInt1");
            SortedList sl2 = new SortedList("slInt2");

            // Instantiate sorted list for string
            SortedList slString = new SortedList("slString");

            // populate string sorted list
            slString.Add("Al");
            slString.Add("Gabriel");
            slString.Add("Enzo");
            slString.Add("Anna");

            // populate int sorted list # 1
            sl1.Add(5);
            sl1.Add(1);
            sl1.Add(7);
            sl1.Add(55);
            sl1.Add(20);
            sl1.Add(9);

            // populate int sorted list # 2
            sl2.Add(6);
            sl2.Add(2);
            sl2.Add(8);
            sl2.Add(56);
            sl2.Add(21);
            sl2.Add(10);

            // display sorted list # 1
            sl1.DisplayInt();

            // display sorted list # 2
            sl2.DisplayInt();

            // display sorted list (string)
            slString.Display();

            // merge list 1 and 2
            SortedList slFinal = Merge(sl1, sl2);

            // display merged list (this is sorted)
            slFinal.DisplayInt();

            
        }

        static SortedList Merge(SortedList list1, SortedList list2)
        {
            SortedList final = list1;
            final.SetName("mergedList");

            ListNode tempNode = list2.firstNode;

            while (tempNode != null)
            {
                ListNode tempNode2 = new ListNode(tempNode.IntData);
                ListNode currNode = final.firstNode;
                ListNode prevNode = null;

                while (currNode != null && currNode.IntData < tempNode2.IntData)
                {
                    prevNode = currNode;
                    currNode = currNode.Next;
                }

                if (prevNode == null)
                {
                    final.firstNode = tempNode2;
                    final.firstNode.Next = currNode;
                }
                else
                {
                    prevNode.Next = tempNode2;
                    tempNode2.Next = currNode;
                }

                tempNode = tempNode.Next;
            }


            return final;
        }
    }
}
