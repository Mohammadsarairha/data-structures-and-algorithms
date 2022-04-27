using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTree
    {
        public Node root { get; set; }

        public BinaryTree()
        {
            root = null;
        }

        //Pre-order: root >> left >> right

        public List<int> PreOrder(Node node)
        {
            List<int> result = new List<int>();

            if (node == null)
            {
                return null;
            }

            Stack<Node> nodeStack = new Stack<Node>();

            nodeStack.Push(root);

            while (nodeStack.Count > 0)
            {
                Node mynode = nodeStack.Peek();

                result.Add(mynode.value);

                nodeStack.Pop();

                if (mynode.right != null)
                {
                    nodeStack.Push(mynode.right);
                }
                if (mynode.left != null)
                {
                    nodeStack.Push(mynode.left);
                }
            }

            return result;
        }

        //In-order: left >> root >> right
        public List<int> InOrder(Node node)
        {
            List<int> result = new List<int>();

            if (root == null)
            {
                return null;
            }
            Stack<Node> s = new Stack<Node>();
            Node curr = root;

            while (curr != null || s.Count > 0)
            {
                while (curr != null)
                {
                    s.Push(curr);
                    curr = curr.left;
                }
                curr = s.Pop();

                result.Add(curr.value);
                curr = curr.right;
            }
            return result;
        }

        //Post-order: left >> right >> root
        public void PostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            if (node.left != null)
            {
                PreOrder(node.left);
            }

            if (node.right != null)
            {
                PreOrder(node.right);
            }

            Console.Write(node.value + " ");

        }

        public int TreeMax()
        {
            if (root == null)
            {
                return 0;
            }

            int max = root.value;

            Stack<Node> nodeStack = new Stack<Node>();

            nodeStack.Push(root);

            while (nodeStack.Count > 0)
            {
                Node node = nodeStack.Peek();

                if (node.value > max)
                {
                    max = node.value;
                }
                nodeStack.Pop();

                if (node.right != null)
                {
                    nodeStack.Push(node.right);
                }
                if (node.left != null)
                {
                    nodeStack.Push(node.left);
                }
            }

            return max;
        }

        public List<int> TreeBreadthFirst(BinaryTree tree)
        {
            List<int> result = new List<int>();

            if (tree.root == null)
            {
                return null;
            }

            Queue<Node> queueNodes = new Queue<Node>();

            queueNodes.Enqueue(tree.root);

            while (queueNodes.Count > 0)
            {
                Node newNode = queueNodes.Peek();

                result.Add(newNode.value);

                queueNodes.Dequeue();

                if (newNode.left != null)
                {
                    queueNodes.Enqueue(newNode.left);
                }
                if (newNode.right != null)
                {
                    queueNodes.Enqueue(newNode.right);
                }
            }

            return result;
        }

    }
}
