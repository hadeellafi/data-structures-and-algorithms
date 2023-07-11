using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class Node
    {
        public int data;
        public Node next;

        public Node()
        {
            next = null;
        }

        public Node(int d, Node n = null)
        {
            data = d;
            next = n;
        }
    }
    public class List
    {
        public Node head { get; set; }
        public Node tail { get; set; }

        public List()
        {
            head = null;
            tail = null;
        }
        public bool IsEmpty()
        {
            return head == null;
        }

        public void InsertFirst(int el)
        {
            if (IsEmpty())
                head = tail = new Node(el);
            else
            {
                head = new Node(el, head);
            }
        }

        public bool IsInclude(int el)
        {
            for (Node t = head; t != null; t = t.next)
            {
                if (t.data == el)
                    return true;
            }
            return false;
        }
        public string ToString()
        {
            string sum = "";
            for (Node t = head; t != null; t = t.next)
            {
                sum += "{" + t.data + "}" + "->";
            }
            return sum + "Null";
        }

        /////////////////CC06 methods

        public void InsertEnd(int el)
        {
            if (IsEmpty())
                head = tail = new Node(el);
            else
            {
                tail.next = new Node(el);
                tail = tail.next;
            }
            ///tail=tail.next=new node(el);
        }
        public void InsertBefore(int pos, int el)
        {
            if (IsInclude(pos))
            {

                if (pos == head.data)
                    InsertFirst(el);
                else
                {
                    Node t = head;
                    for (; t != null; t = t.next)
                    {
                        if (t.next.data == pos)
                            break;
                    }
                    t.next = new Node(el, t.next);
                }
            }
        }
        public void InsertAfter(int pos, int el)
        {
            if (IsInclude(pos))
            {

                if (pos == tail.data)
                    InsertEnd(el);
                else
                {
                    Node t = head;
                    for (; t != null; t = t.next)
                    {
                        if (t.data == pos)
                            break;
                    }
                    t.next = new Node(el, t.next);
                }
            }
        }
        public void DeleteNodeByValue(int el)
        {
            if (IsInclude(el))
            {
                if (head.data == el)//delete head
                {
                    head = head.next;
                }
                else if (tail.data == el) // Delete tail
                {
                    Node t = head;
                    while (t.next != tail)
                        t = t.next;

                    tail = t;
                    tail.next = null;

                }

                else      //delete in middle
                {
                    Node t = head;
                    while (t.next.data != el)
                        t = t.next;
                    t.next = t.next.next;
                }
            }
        }
        public int Size()
        {
            int c = 0;
            Node t = head;
            for (; t != null; t = t.next)
                c++;
            return c;
        }


        public int kthFromEnd(int k)
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot perform kthFromEnd operation on an empty linked list.");
            }

            if (k < 0)
            {
                throw new ArgumentException("Invalid value of k. k must be a non-negative integer.");
            }

            int size = Size();

            if (k >= size)
            {
                throw new ArgumentException("Invalid value of k. k exceeds the length of the list.");
            }

            Node t = head;
            int i = 1;
            int targetIndex = size - k;

            while (i < targetIndex)
            {
                t = t.next;
                i++;
            }

            return t.data;
        }
        /////////////////////////Lab08///////////////////////////////////
       public List zipLists(List list1,List list2)
        {
            List result=new List();

            Node temp1 = list1.head;
            Node temp2 = list2.head;
            while(temp1!=null && temp2!=null)
            {
                result.InsertEnd(temp1.data);
                result.InsertEnd(temp2.data);

                temp1=temp1.next;
                temp2=temp2.next;

            }
            while (temp1 != null)
            {
                result.InsertEnd(temp1.data);
                temp1 = temp1.next;
            }

            while (temp2 != null)
            {
                result.InsertEnd(temp2.data);
                temp2 = temp2.next;
            }

            return result;

        }
        public List reverseList(List listToreverse)
        {
            Node current = listToreverse.head;
            Node previous = null;
            Node next = null;
            while (current != null)
            {
                next=current.next;
                current.next = previous;
                previous=current;
                current=next;
            }
            listToreverse.tail = listToreverse.head;
            listToreverse.head = previous;

            return listToreverse;
        }
           


    }
}
