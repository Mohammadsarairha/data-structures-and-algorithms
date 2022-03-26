using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListsApp
{
    public class Node
    {
        public object value;
        public Node next;

        // contractor for initial value
        public Node(object value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
