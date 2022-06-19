using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Intersection
{
    public class BinarySearchTree  : BinaryTree
    {
        public void Add(int value)
        {
            Node before = null;

            Node after = this.root;

            while (after != null)
            {
                before = after;
                if (value < after.value)
                    after = after.left;
                else if (value > after.value)
                    after = after.right;
            }

            Node newNode = new Node(value);

            if (this.root == null)
                this.root = newNode;
            else
            {
                if (value < before.value)
                    before.left = newNode;
                else
                    before.right = newNode;
            }
        }
        public bool Contains(int value)
        {
            if (root == null)
            {
                return false;
            }

            Node current = root;

            while (current != null)
            {
                if (current.value == value)
                {
                    return true;
                }
                else if (value < current.value)
                {
                    current = current.left;
                }
                else if (value > current.value)
                    current = current.right;
            }

            return false;
        }
    }
}
