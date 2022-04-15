using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_pseudo
{
    public class PseudoQueue
    {
         Stack stack1 = new Stack();
         Stack stack2 = new Stack();

        //Inserts value using a first-in, first-out approach.
        public void Enqueue(object value)
        {
            while (stack1.top != null)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(value);

            while (stack2.top != null)
            {
                stack1.Push(stack2.Pop());
            }
        }

        //Extracts a value using a first-in, first-out approach.
        public object Dequeue()
        {
            if (stack1.top == null)
            {
                return null;
            }

            // Return top of s1
            object temp = stack1.Peek();
            stack1.Pop();

            return temp;
        }
    }
}
