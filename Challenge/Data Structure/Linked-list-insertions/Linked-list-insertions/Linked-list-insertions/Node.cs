using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list_insertions
{
    public class Node
    {
        public object value{ get; set; }
        public Node next { get; set; }

        // contractor for initial value
        public Node(object value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
