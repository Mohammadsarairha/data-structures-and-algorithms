using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list_zip
{
    public class LinkedList
    {
        public Node head { get; set; }


        public static LinkedList ZipLists(LinkedList list1, LinkedList list2)
        {
            Node current1 = list1.head;
            Node current2 = list2.head;
            Node lastNode = list1.head;
            while (current2 != null)
            {
                if (lastNode == null)
                {
                    current2 = current2.Next;
                }

                if (current1.Next == null)
                {
                    current1.Next = current2;
                    lastNode = null;
                }
                else
                {
                    current1 = current1.Next;
                }
            }
            return list1;
        }

        public void Append(object value)
        {
            Node current = head;
            Node temp = new Node(value);
            if (current == null)
            {
                head = temp;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = temp;
            }
        }
    }
}
