using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTree
{
    public class Node
    {
        public Node left { get; set; }
        public Node right { get; set; }

        public object value { get; set; }

        public Node(object value)
        {
            this.value = value;
            left = right = null;
        }
    }
}
