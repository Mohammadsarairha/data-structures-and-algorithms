using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list_insertions
{
    public class Linked_List
    {
        public Node head { get; set; }

        public Linked_List(object value)
        {
            head = new Node(value);
        }

        // Function to adds a new node with the given value to the end of the list

        public void Append(object value)
        {
            Node current = head;
            Node temp = new Node(value);

            while (current.next != null)
            {
                current =current.next;
            }
            current.next = temp;
        }

        // Function to adds a new node with the given new value immediately before the first node that has the value specified

        public void InsertBefore(object beforValue,object newValue)
        {
            Node current = head;
            Node temp = new Node(newValue);
            while (current != null)
            {
                if (beforValue.Equals(current.value))
                {
                    temp.next = head;
                    head = temp;
                    break;
                }

                if(beforValue.Equals(current.next.value))
                {
                    temp.next = current.next;
                    current.next = temp;
                    break;
                }
                current = current.next;
            }

        }

        // Function to adds a new node with the given new value immediately after the first node that has the value specified

        public void InsertAfter(object afterValue, object newValue)
        {
            Node current = head;
            Node temp = new Node(newValue);

            while (current != null)
            {
                if (afterValue.Equals(current.value))
                {
                    temp.next = current.next;
                    current.next = temp;
                    break;
                }
                current = current.next;
            }
        }
    }
}
