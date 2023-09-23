using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class TreeIntersection
    {
        public HashSet<int> TreeIntersectionMethod(TreeNode root1, TreeNode root2)
        {
            HashSet<int> result = new HashSet<int>();
            HashTable hashTable = new HashTable(20);

            Traverse(root1, hashTable);
            CheckIntersection(root2, hashTable, result);

            return result;
        }

        private void Traverse(TreeNode node, HashTable hashTable)
        {
            if (node == null)
                return;

            hashTable.Set(node.Value.ToString(), node.Value.ToString());
            Traverse(node.Left, hashTable);
            Traverse(node.Right, hashTable);
        }

        private void CheckIntersection(TreeNode node, HashTable hashTable, HashSet<int> result)
        {
            if (node == null)
                return;

            if (hashTable.Has(node.Value.ToString()))
                result.Add(node.Value);

            CheckIntersection(node.Left, hashTable, result);
            CheckIntersection(node.Right, hashTable, result);
        }
    }

}
