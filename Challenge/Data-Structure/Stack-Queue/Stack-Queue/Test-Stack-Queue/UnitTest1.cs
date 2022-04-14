using System;
using Xunit;
using Stack_Queue;
namespace Test_Stack_Queue
{
    public class UnitTest1
    {
        //Test push onto a stack
        [Fact]
        public void Test1()
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.Equal(1,stack.top.Value);
        }

        //Test push multiple values onto a stack
        [Fact]
        public void Test2()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.Equal(3, stack.top.Value);
        }

        //Test pop off the stack
        [Fact]
        public void Test3()
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.Equal(1, stack.Pop());
        }

        //Test empty a stack after multiple pops
        [Fact]
        public void Test4()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            stack.Pop();
            Assert.Null(stack.Pop());
        }

        //Test peek the top item on the stack
        [Fact]
        public void Test5()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            Assert.Equal(2,stack.Peek());
        }

        //Test to instantiate an empty stack
        [Fact]
        public void Test6()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
        }

        //Test to peek from empty stack
        [Fact]
        public void Test7()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Peek());
        }

        //Test to enqueue into a queue
        [Fact]
        public void Test8()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            Assert.Equal(1,queue.front.Value);
        }

        //Test to enqueue multiple values into a queue
        [Fact]
        public void Test9()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.Equal(3, queue.rear.Value);
        }

        //Test to dequeue out of a queue the expected value
        [Fact]
        public void Test10()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            Assert.Equal(1, queue.Dequeue());
        }

        //Test to peek into a queue
        [Fact]
        public void Test11()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Assert.Equal(1, queue.Peek());
        }

        //Test empty a queue after multiple dequeues
        [Fact]
        public void Test12()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();
            queue.Dequeue();
            Assert.Null(queue.Dequeue());
        }

        //Test to instantiate an empty queue
        [Fact]
        public void Test13()
        {
            Queue queue = new Queue();
            Assert.Null(queue.front.Value);
        }

        //Test to dequeue or peek on empty queue raises exception
        [Fact]
        public void Test14()
        {
            Queue queue = new Queue();
            Assert.Null(queue.Dequeue());
        }
    }
}
