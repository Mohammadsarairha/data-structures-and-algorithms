using System;
using Xunit;
using SinglyLinkedListsApp;

namespace TestLinkedList
{
    public class UnitTest1
    {
        
        //Test instantiate an empty linked list
        [Fact]
        public void Test1()
        {
            LinkedList list = new LinkedList();
            Assert.Null(list.head);
        }

        //Test for insert into the linked list
        [Fact]
        public void Test2()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            Assert.True(list.Include(5));
        }

        //Test the head property will properly point to the first node in the linked list
        [Fact]
        public void Test3()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert("Bye");
            list.Insert("Hi");
            list.Insert(10);
            Assert.Equal(10,list.head.value);
        }
        //Tset if can properly insert multiple nodes into the linked list
        [Fact]
        public void Test4()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert("Bye");
            list.Insert("Hi");
            list.Insert(10);
            Assert.True(list.Include("Hi"));
        }

        //Test to return true when finding a value within the linked list that exists
        [Fact]
        public void Test5()
        {
            LinkedList list = new LinkedList();
            list.Insert(10);
            list.Insert(3);
            list.Insert(5);
            Assert.True(list.Include(10));
        }

        // Test to return false when searching for a value in the linked list that does not exist
        [Fact]
        public void Test6()
        {
            LinkedList list = new LinkedList();
            list.Insert(10);
            list.Insert(3);
            list.Insert(5);
            Assert.False(list.Include(100));
        }

        //Test to return a collection of all the values that exist in the linked list
        [Fact]
        public void Test7()
        {
            LinkedList list = new LinkedList();
            list.Insert(10);
            list.Insert(3);
            list.Insert(5);
            Assert.Equal("[ 5 ] -> [ 3 ] -> [ 10 ] -> NULL", list.Tostring());
        }

    }
}
