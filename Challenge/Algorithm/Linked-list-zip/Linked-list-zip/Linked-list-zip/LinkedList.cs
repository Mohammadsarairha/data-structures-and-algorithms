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

            while (current2 != null)
            {
                if (current1 == null)
                {
                    list1.Append(current2.Value);
                    current2 = current2.Next;
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
