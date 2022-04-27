using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Node
    {
        public Node left { get; set; }
        public Node right { get; set; }

        public int value { get; set; }

        public Node(int value)
        {
            this.value = value;
            left = right = null;
        }
    }
}
