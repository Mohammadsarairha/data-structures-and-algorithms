using System;

namespace FizzBuzzTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.root = new Node(5);
            tree.root.right = new Node(3);
            tree.root.left = new Node(2);
            tree.root.right.right = new Node(6);
            tree.root.left.left = new Node(15);
            tree.root.left.right = new Node(1);

            Tree fizzbuzz = tree.fizzBuzzTree(tree);

            //fizzbuzz.PrintTree();
            // Console.WriteLine();
            //tree.PrintTree();

            // Buzz 2 FizzBuzz 1 Fizz Fizz
            // 5 2 15 1 3 6
        }
    }
}
