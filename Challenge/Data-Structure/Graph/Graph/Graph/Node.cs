using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Node
    {
        public int data;
        public HashSet<Edge> neighbors;

        public Node(int data)
        {
            this.data = data;
            neighbors = new HashSet<Edge>();
        }
        public void addNeighbor(Node node)
        {
            Edge edge = new Edge(node);
            neighbors.Add(edge);
        }
    }
}
