using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Edge
    {
        public int weight;
        public Node node;


        public Edge(Node node)
        {
            this.node = node;
        }

        public Edge(Node node, int weight)
        {
            this.node = node;
            this.weight = weight;
        }

        public Node getNode()
        {
            return node;
        }
    }
}
