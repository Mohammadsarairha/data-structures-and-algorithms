using System;
using Xunit;
using LinkedListKth;

namespace Test_LinkedListKth
{
    public class UnitTest1
    {
        // Test if k is greater than the length of the linked list
        [Fact]
        public void Test1()
        {
            LinkedList list = new LinkedList(1);
            list.Insert(3);
            list.Insert(8);
            list.Insert(2);
            Assert.Equal(2, list.kthFromEnd(0));
        }

        //Test if k and the length of the list are the same
        [Fact]
        public void Test2()
        {
            LinkedList list = new LinkedList(1);
            list.Insert(3);
            list.Insert(8);
            list.Insert(2);
            Assert.Equal(1, list.kthFromEnd(3));
        }

        //Test if k is not a positive integer
        [Fact]
        public void Test3()
        {
            LinkedList list = new LinkedList(1);
            list.Insert(3);
            list.Insert(8);
            list.Insert(2);
            Assert.Equal("Please enter positive number", list.kthFromEnd(-1));
        }

        //Test if the linked list is of a size 1
        [Fact]
        public void Test4()
        {
            LinkedList list = new LinkedList(1);
            Assert.Equal(1, list.kthFromEnd(0));
        }

        // Test if k is not at the end, but somewhere in the middle of the linked list
        [Fact]
        public void Test5()
        {
            LinkedList list = new LinkedList(1);
            list.Insert(3);
            list.Insert(8);
            list.Insert(2);
            Assert.Equal(3, list.kthFromEnd(2));
        }

    }
}
