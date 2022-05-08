using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTree
{
    public class Tree
    {
        public Node root { get; set; }

        public Tree()
        {
            root = null;
        }

        public Tree fizzBuzzTree(Tree tree)
        {
            Tree fizzBuzz = new Tree();

            Stack<Node> nodeStack = new Stack<Node>();

            Stack<Node> newNodeStack = new Stack<Node>();

            fizzBuzz.root = new Node(GetFizzBuzz(tree.root.value));

            nodeStack.Push(tree.root);
            newNodeStack.Push(fizzBuzz.root);

            while (nodeStack.Count > 0)
            {
                Node node = nodeStack.Peek();
                Node fizzBuzzRoot = newNodeStack.Peek();

                nodeStack.Pop();
                newNodeStack.Pop();

                if (node.right != null)
                {
                    fizzBuzzRoot.right = new Node(GetFizzBuzz(node.right.value));

                    nodeStack.Push(node.right);
                    newNodeStack.Push(fizzBuzzRoot.right);
                }
                if (node.left != null)
                {
                    fizzBuzzRoot.left = new Node(GetFizzBuzz(node.left.value));

                    nodeStack.Push(node.left);
                    newNodeStack.Push(fizzBuzzRoot.left);
                }
            }
            return fizzBuzz;
        }


        private String GetFizzBuzz(object value)
        {
            if (Convert.ToInt32(value) % 3 == 0 && Convert.ToInt32(value) % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (Convert.ToInt32(value) % 5 == 0)
            {
                return "Buzz";
            }
            else if (Convert.ToInt32(value) % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return $"{value}";
            }
        }

        public List<string> TreeList()
        {
            Stack<Node> nodeStack = new Stack<Node>();
            List<string> list = new List<string>();

            nodeStack.Push(root);

            while (nodeStack.Count > 0)
            {
                Node node = nodeStack.Peek();
                list.Add($"{node.value}");
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

            return list;
        }
    }
}
