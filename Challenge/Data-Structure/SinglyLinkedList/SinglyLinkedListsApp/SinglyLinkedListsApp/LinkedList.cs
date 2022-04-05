using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListsApp
{
    public class LinkedList
    {
        public Node head;

        public void Insert(object value)
        {
            Node newNode = new Node(value);
            newNode.next = head;
            head = newNode;
        }

        public bool Include(object value)
        {
            Node current = head;
            while (current != null)
            {
                if(value.Equals(current.value))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public string Tostring()
        {
            string str = "";
            Node current = head;
            while (current != null)
            {
                str += $"[ {current.value} ] -> ";
                current = current.next;
            }

            str += "NULL";
            return str;
        }
    }
}
