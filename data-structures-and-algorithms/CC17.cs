﻿using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms
{
    public class CC17<T> where T : IComparable
    {
        public List<T> BreadthFirst(BinaryTree<T> tree)
        {
            if (tree.Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }
            List<T> list = new List<T>();
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(tree.Root);

            while (queue.Count > 0)
            {
                Node<T> current = queue.Dequeue();
                list.Add(current.Value);

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            return list;
        }
    }
}
