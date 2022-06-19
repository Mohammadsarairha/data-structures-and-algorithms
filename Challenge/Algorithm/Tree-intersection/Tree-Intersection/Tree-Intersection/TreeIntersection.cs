using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Intersection
{
    public class TreeIntersection
    {
        public static Hashtable treeIntersection(BinarySearchTree tree1, BinarySearchTree tree2)
        {

            Hashtable intersection = new Hashtable();

            Hashtable set1 = setTreeToHash(tree1);
            Hashtable set2 = setTreeToHash(tree2);

            foreach(var item in set1)
            {
                if (tree1.Contains(int.Parse(item.ToString())))
                {
                    intersection.Add(item.ToString(), item.ToString());
                }
            }
            return intersection;
        }

        public static Hashtable setTreeToHash(BinarySearchTree bt)
        {
            Hashtable nodeSet = new Hashtable();

            foreach(var item in nodeSet)
            {
                nodeSet.Add(item.ToString(), item.ToString());
            }
            return nodeSet;
        }
    }
}
