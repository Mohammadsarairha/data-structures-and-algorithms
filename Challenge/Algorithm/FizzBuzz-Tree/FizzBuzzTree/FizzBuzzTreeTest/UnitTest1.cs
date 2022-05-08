using System;
using Xunit;
using FizzBuzzTree;
using System.Collections.Generic;

namespace FizzBuzzTreeTest
{
    public class UnitTest1
    {
        // Test Fizz Buzz Tree if the value is divisible by 3, replace the value with Fizz
        [Fact]
        public void Test1()
        {
            Tree tree = new Tree();
            tree.root = new Node(3);

            Tree fizzbuzz = tree.fizzBuzzTree(tree);

            Assert.Equal("Fizz", fizzbuzz.root.value );
        }

        // Test Fizz Buzz Tree if the value is divisible by 5, replace the value with Buzz
        [Fact]
        public void Test2()
        {
            Tree tree = new Tree();
            tree.root = new Node(5);

            Tree fizzbuzz = tree.fizzBuzzTree(tree);

            Assert.Equal("Buzz", fizzbuzz.root.value);
        }

        // Test Fizz Buzz Tree if the value is divisible by 3 and 5, replace the value with FizzBuzz
        [Fact]
        public void Test3()
        {
            Tree tree = new Tree();
            tree.root = new Node(15);

            Tree fizzbuzz = tree.fizzBuzzTree(tree);

            Assert.Equal("FizzBuzz", fizzbuzz.root.value);
        }

        // Test Fizz Buzz Tree if the value is not divisible by 3 or 5, simply turn the number into a String.
        [Fact]
        public void Test4()
        {
            Tree tree = new Tree();
            tree.root = new Node(1);

            Tree fizzbuzz = tree.fizzBuzzTree(tree);

            Assert.Equal("1", fizzbuzz.root.value);
        }

        // Test if all node have Fizz Buzz rules .
        [Fact]
        public void Test5()
        {
            Tree tree = new Tree();
            tree.root = new Node(5);
            tree.root.right = new Node(3);
            tree.root.left = new Node(2);
            tree.root.right.right = new Node(6);
            tree.root.left.left = new Node(15);
            tree.root.left.right = new Node(1);

            Tree fizzbuzz = tree.fizzBuzzTree(tree);

            List<string> list = new List<string> {"Buzz" ,"2" , "FizzBuzz", "1" ,"Fizz","Fizz"};


            Assert.Equal(list, fizzbuzz.TreeList());
        }
    }
}
