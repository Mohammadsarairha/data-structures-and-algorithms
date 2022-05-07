using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTree
    {
        public Node root { get; set; }

        public BinaryTree()
        {
            root = null;
        }

        //Pre-order: root >> left >> right
        public List<int> PreOrder(Node node)
        {
            if (node == null)
                throw new Exception("Tree is empty!");

            List<int> list = new List<int>();
            return GetPreOrder(list,node);
        }
        private List<int> GetPreOrder(List<int> list, Node node)
        {
            list.Add(node.value);

            if (node.left != null)
                GetPreOrder(list, node.left);
            if (node.right != null)
                GetPreOrder(list, node.right);

            return list;
        }
        public List<int> InOrder(Node node)
        {
            if (node == null)
                throw new Exception("Tree is empty!");

            List<int> list = new List<int>();
            
            return GetInOrder(list, node);
        }
        //In-order: left >> root >> right
        private List<int> GetInOrder(List<int> list , Node node)
        {
            if (node.left != null)
                GetInOrder(list, node.left);

            list.Add(node.value);

            if (node.right != null)
                GetInOrder(list, node.right);

            return list;
        }
        //Post-order: left >> right >> root
        public List<int> PostOrder(Node node)
        {
            if (node == null)
                throw new Exception("Tree is empty!");

            List<int> list = new List<int>();

            return GetPostOrder(list, node);
        }
        //In-order: left >> root >> right
        private List<int> GetPostOrder(List<int> list, Node node)
        {
            if (node.left != null)
                GetPostOrder(list, node.left);

            if (node.right != null)
                GetPostOrder(list, node.right);

            list.Add(node.value);

            return list;
        }
    }
}
