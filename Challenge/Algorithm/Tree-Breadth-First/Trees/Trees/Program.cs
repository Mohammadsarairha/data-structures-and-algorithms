using System;
using System.Collections.Generic;

namespace Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            //50 20 18 22 40 90 80 100
            List<int> result = tree.TreeBreadthFirst(tree);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
