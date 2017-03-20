using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;
using System.Collections;

namespace Q2
{
    // This is a class that implements the List class under the LinkedListLibrary project
    public class SortedList : LinkedListLibrary.List
    {
        public SortedList(string listName) : base(listName)
        {

        }

        // method to add a new integer item
        public void Add(int addItem)
        {
            // check if list is empty
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(addItem);
            }
            else
            {
                ListNode tempNode = new ListNode(addItem);
                ListNode currNode = firstNode;
                ListNode prevNode = null;

                // find the correct position to insert the new node
                while(currNode != null && currNode.IntData < addItem)
                {
                    prevNode = currNode;
                    currNode = currNode.Next;
                }

                // if previous node is null, that means there is only 1 node that currently exists
                if(prevNode == null)
                {
                    firstNode = tempNode;
                    firstNode.Next = currNode;
                }
                else 
                {
                    prevNode.Next = tempNode; // set the newly inserted node as the previous node's Next property
                    tempNode.Next = currNode; // set the current node as the newly inserted node's Next property
                }
            }
            
        }

        // method to add a new string item
        public void Add(string addItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(addItem);
            }
            else
            {
                ListNode tempNode = new ListNode(addItem);
                ListNode currNode = firstNode;
                ListNode prevNode = null;

                while (currNode != null && currNode.Data.ToString().CompareTo(addItem) < 0)
                {
                    prevNode = currNode;
                    currNode = currNode.Next;
                }

                if (prevNode == null)
                {
                    firstNode = tempNode;
                    firstNode.Next = currNode;
                }
                else
                {
                    prevNode.Next = tempNode;
                    tempNode.Next = currNode;
                }
            }

        }
        
    }
}
