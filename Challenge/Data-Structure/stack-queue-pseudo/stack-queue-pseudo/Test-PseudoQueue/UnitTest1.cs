using System;
using Xunit;
using stack_queue_pseudo;

namespace Test_PseudoQueue
{
    public class UnitTest1
    {
        //Test to add new element to empty pseudo queue
        [Fact]
        public void Test1()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(1);

            Assert.Equal(1, queue.Dequeue());
        }

        //Test to add multiple elements to pseudo queue using(FIFO) approach
        [Fact]
        public void Test2()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.Equal(1, queue.Dequeue());
        }

        //Test to create empty pseudo queue
        [Fact]
        public void Test3()
        {
            PseudoQueue queue = new PseudoQueue();

            Assert.Null(queue.Dequeue());
        }
    }
}
