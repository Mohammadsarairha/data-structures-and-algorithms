using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class MyHashTable
    {
        private static int tableSize;
        private Node[] Table { get; set; }

        public MyHashTable(int size)
        {
            tableSize = size;
            Table = new Node[tableSize];
        }


        public void Set(string key, string value)
        {
            int index = Hash(key);
            Node newNode = new Node(key, value);

            if (Table[index] == null)
            {
                Table[index] = newNode;
            }
            else
            {
                Node current = Table[index];
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(key, value);
            }
        }


        public Node Get(string key)
        {
            int index = Hash(key);
            Node current = Table[index];

            while (current != null)
            {
                if (current.Key == key)
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }


        public bool Contains(string key)
        {
            int index = Hash(key);
            Node current = Table[index];

            while (current != null)
            {
                if (current.Key == key)
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public int Hash(string key)
        {
            int hash = 0;

            foreach (int character in key)
            {
                hash += character;
            }

            return hash * 599 % 1024;
        }

    }
}
