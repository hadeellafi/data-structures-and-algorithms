using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace data_structures_and_algorithms
{
    internal class CC05
    {
    }

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
            for(Node t=head;t!=null;t=t.next)
            {
                if(t.data==el)
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
            return sum+"Null";
        }
    }
}
   
