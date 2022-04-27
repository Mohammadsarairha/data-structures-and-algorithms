using System;
using System.Collections.Generic;

namespace Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(2);
            tree.root.left = new Node(7);
            tree.root.right = new Node(5);
            tree.root.left.left = new Node(2);
            tree.root.left.right = new Node(6);
            tree.root.left.right.left = new Node(5);
            tree.root.left.right.right = new Node(11);
            tree.root.right.right = new Node(9);
            tree.root.right.right.left = new Node(41);
            //50 20 18 22 40 90 80 100
            Console.WriteLine(tree.TreeMax());
        }
    }
}
