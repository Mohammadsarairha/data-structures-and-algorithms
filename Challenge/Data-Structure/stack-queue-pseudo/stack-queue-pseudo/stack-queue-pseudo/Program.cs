using System;

namespace stack_queue_pseudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PseudoQueue pseudoQueue = new PseudoQueue();

            pseudoQueue.Enqueue(1);
            pseudoQueue.Enqueue(2);
            pseudoQueue.Enqueue(3);
            pseudoQueue.Enqueue(4);
            Console.WriteLine(pseudoQueue.Dequeue());
            Console.WriteLine(pseudoQueue.Dequeue());
            Console.WriteLine(pseudoQueue.Dequeue());
            Console.WriteLine(pseudoQueue.Dequeue());
        }
    }
}
