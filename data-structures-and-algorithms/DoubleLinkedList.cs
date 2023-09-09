using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class DLLNode
    {
        public int data;
        public DLLNode next;
        public DLLNode previous;


        

        public DLLNode(int d,  DLLNode p=null, DLLNode n = null)
        {
            data = d;
            next = n;
            previous = p;
        }
    }
    public class DoubleLinkedList
    {
        public DLLNode head { get; set; }
       
        public DoubleLinkedList() {
            head = null;
           
        }
        public void insertAtEnd(int data)
        {
            if(head == null)
            {
                head = new DLLNode(data);
            }
            else
            {
                DLLNode temp = head;
                for (; temp.next != null; temp = temp.next) ;
                temp.next=new DLLNode(data,temp);  

            }
        }
        public void insertAtFirst(int data)
        {
            if (head == null)
            {
                head = new DLLNode(data);
            }
            else
            {
                head.previous = new DLLNode(data, null, head); // only assign to head.previous
                head = head.previous; // update head to point to new node
            }
        }

        public void insertAfterElement(int el,int data)
        {
            DLLNode temp=head;
            for (; temp.data != el; temp = temp.next) ;
            temp.next = new DLLNode(data,temp,temp.next);
        }
        public void insertBeforeElement(int el, int data)
        {
            DLLNode temp = head;
            for (; temp.next.data != el; temp = temp.next) ;
            DLLNode newNode = new DLLNode(data);
            newNode.previous = temp;
            newNode.next = temp.next;
            temp.next.previous = newNode;
            temp.next = newNode;
        }
    }
}
