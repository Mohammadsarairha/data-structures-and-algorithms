using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListKth
{
    public class LinkedList
    {
        public Node head { get; set; }

        public LinkedList(object value)
        {
            head = new Node(value);
        }

        public object kthFromEnd(int k)
        {
            Node current = head;
            if (k >= 0)
            {
                for (int i = 0; i < k; i++)
                {
                    try
                    {
                        current = current.next;
                    }
                    catch (NullReferenceException ex)
                    {
                        return ex.Message;
                    }
                }
                return current.value;
            }
            else
            {
                return "Please enter positive number";
            }
        }

        public void Insert(object value)
        {
            Node newNode = new Node(value);
            newNode.next = head;
            head = newNode;
        }
    }
}
