using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_list_zip
{
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }

        public Node(object Value)
        {
            this.Value = Value;
            this.Next = null;
        }
    }
}
