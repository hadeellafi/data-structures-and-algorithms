using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace data_structures_and_algorithms
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }
        public BinaryTree()
        {
            Root = null;
        }

        public List<T> PreOrderTraversal()
        {
            List<T> list = new List<T>();
            PreOrder(Root, list);
            return list;
        }

        public void PreOrder(Node<T> r, List<T> l)
        {
            if (r != null)
            {
                l.Add(r.Value);
                PreOrder(r.Left, l);
                PreOrder(r.Right, l);
            }
        }

        public List<T> InOrderTraversal()
        {
            List<T> list = new List<T>();
            InOrder(Root, list);
            return list;
        }

        public void InOrder(Node<T> r, List<T> l)
        {
            if (r != null)
            {
                InOrder(r.Left, l);
                l.Add(r.Value);
                InOrder(r.Right, l);
            }
        }

        public List<T> PostOrderTraversal()
        {
            List<T> list = new List<T>();
            PostOrder(Root, list);
            return list;
        }

        public void PostOrder(Node<T> r, List<T> l)
        {
            if (r != null)
            {
                PostOrder(r.Left, l);
                PostOrder(r.Right, l);
                l.Add(r.Value);
            }
        }
    }
    public class BinarySearchTree<T>: BinaryTree<T> where T : IComparable
    {
        public void Add(T value)
        {
             Root=Add(value, Root);
        }
        public Node<T> Add(T value,Node<T>r)
        {
            if (r == null)
                return new Node<T>(value);
            
                int compar = value.CompareTo(r.Value);

                if (compar < 0)
                    r.Left = Add(value,r.Left);
                else if (compar > 0)
                    r.Right = Add(value, r.Right);
                return r;
            
        }

        public bool Contains(T value)
        {
            return Search(value, Root);
        }

        public bool Search(T value, Node<T> r)
        {
            if (r == null)
                return false;

            int comparison = value.CompareTo(r.Value);

            if (comparison == 0)
                return true;
            else if (comparison < 0)
                return Search(value, r.Left);
            else
                return Search(value, r.Right);
        }
    }
    
}
