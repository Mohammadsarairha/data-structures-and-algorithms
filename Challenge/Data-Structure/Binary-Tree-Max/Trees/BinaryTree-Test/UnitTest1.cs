using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace BinaryTree_Test
{
    public class UnitTest1
    {
        //Can successfully instantiate an empty tree
        [Fact]
        public void Test1()
        {
            BinaryTree tree = new BinaryTree();

            Assert.Null(tree.root);
        }

        //Can successfully instantiate a tree with a single root node
        [Fact]
        public void Test2()
        {
            BinaryTree tree = new BinaryTree();
            Node node = new Node(40);
            tree.root = node;
            Assert.Null(tree.root.right);
        }

        //can successfully add a left child and right child properly to a node
        [Fact]
        public void Test3()
        {
            BinarySearchTree binaryTree = new BinarySearchTree();
            binaryTree.root = new Node(60);
            binaryTree.root.left = new Node(20);
            binaryTree.root.right = new Node(80);
            Assert.Equal(20,binaryTree.root.left.value);
        }
        //Return true for the contains method, given an existing node value
        [Fact]
        public void Test4()
        {
            BinarySearchTree binaryTree = new BinarySearchTree();
            binaryTree.Add(50);
            binaryTree.Add(20);
            binaryTree.Add(90);
            binaryTree.Add(18);
            Assert.True(binaryTree.Contains(18));
        }

        //Return false for the contains method, given an non-existing node value
        [Fact]
        public void Test5()
        {
            BinarySearchTree binaryTree = new BinarySearchTree();
            binaryTree.Add(50);
            binaryTree.Add(20);
            binaryTree.Add(90);
            binaryTree.Add(18);
            Assert.False(binaryTree.Contains(100));
        }

        //Can successfully return a collection from a preorder traversal
        [Fact]
        public void Test6()
        {
            BinarySearchTree binaryTree = new BinarySearchTree();
            binaryTree.Add(50);
            binaryTree.Add(20);
            binaryTree.Add(90);
            binaryTree.Add(18);

            List<int> result = new List<int>() {50,20,18,90};

            Assert.Equal(result, binaryTree.PreOrder(binaryTree.root));
        }
        //Can successfully return a collection from an inorder traversal
        [Fact]
        public void Test7()
        {
            BinarySearchTree binaryTree = new BinarySearchTree();
            binaryTree.Add(50);
            binaryTree.Add(20);
            binaryTree.Add(90);
            binaryTree.Add(18);

            List<int> result = new List<int>() { 18,20,50,90 };

            Assert.Equal(result, binaryTree.InOrder(binaryTree.root));
        }

        [Fact]
        public void Test8()
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
            tree.root.right.right.left = new Node(4);

            Assert.Equal(11, tree.TreeMax());
        }
    }
}
