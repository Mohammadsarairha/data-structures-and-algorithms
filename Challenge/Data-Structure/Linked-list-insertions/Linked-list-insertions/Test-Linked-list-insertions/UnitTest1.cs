using System;
using Xunit;
using Linked_list_insertions;

namespace Test_Linked_list_insertions
{
    public class UnitTest1
    {
        //Add a node to the end of the linked list
        [Fact]
        public void Test1()
        {
            Linked_List list = new Linked_List(8);
            list.Append(9);
            Assert.Equal(9, list.head.next.value );
        }

        //Add multiple nodes to the end of a linked list
        [Fact]
        public void Test2()
        {
            Linked_List list = new Linked_List(8);
            list.Append(9);
            list.Append(10);
            Assert.Equal(10, list.head.next.next.value);
        }

        //Insert a node before a node located i the middle of a linked list
        [Fact]
        public void Test3()
        {
            Linked_List list = new Linked_List(8);
            list.Append(9);
            list.Append(10);
            list.InsertBefore(9,5);
            Assert.Equal(5, list.head.next.value);
        }

        //Insert a node before the first node of a linked list
        [Fact]
        public void Test4()
        {
            Linked_List list = new Linked_List(8);
            list.InsertBefore(8, 5);
            Assert.Equal(5, list.head.value);
        }

        //Insert after a node in the middle of the linked list
        [Fact]
        public void Test5()
        {
            Linked_List list = new Linked_List(8);
            list.Append(9);
            list.Append(10);
            list.InsertAfter(9, 5);
            Assert.Equal(5, list.head.next.next.value);
        }
        //Insert a node after the last node of the linked list
        [Fact]
        public void Test6()
        {
            Linked_List list = new Linked_List(8);
            list.InsertAfter(8, 5);
            Assert.Equal(5, list.head.next.value);
        }   
    }
}
