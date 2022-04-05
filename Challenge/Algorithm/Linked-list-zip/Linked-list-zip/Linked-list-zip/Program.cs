using System;

namespace Linked_list_zip
{
    internal class Program
    {
        static void Main(string[] args)
        {
          LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(3);
            list.Append(2);


          LinkedList list1 = new LinkedList();
            list1.Append(5);
            list1.Append(9);
            list1.Append(4);


            LinkedList list2 = LinkedList.ZipLists(list, list1);

            Node current = list2.head;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
