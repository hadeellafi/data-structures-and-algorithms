/*Note this file hold 2 implemention of both Stack & Queue:
 implement Stack & Queue using list as underlying data storage mechanism 
 implement Stack & Queue without using list as underlying data storage mechanism(as comment at the end of fill)
 and test woks correctly on both
*/

namespace data_structures_and_algorithms
{
    //using list as underlying data storage mechanism 
    public class Stack
    {
        private List list;

        public Stack()
        {
            list = new List();
        }

        public void Push(int el)
        {
            list.InsertFirst(el);
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot pop from an empty stack.");
            }

            int output = list.head.data;
            list.head = list.head.next;

            return output;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot peek an empty stack.");
            }

            return list.head.data;
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }
    }

    public class Queue
    {
        private List list;

        public Queue()
        {
            list = new List();
        }

        public void Enqueue(int el)
        {
            list.InsertEnd(el);
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot dequeue from an empty queue.");
            }

            int output = list.head.data;
            list.head = list.head.next;

            return output;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot peek an empty queue.");
            }

            return list.head.data;
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }
    }
}
//////// implement Stack & Queue without using list as underlying data storage mechanism:

/* 
    public class Stack
    {
        public Node Top { get; set; }
        private int count;
        public Stack()
        {
            Top = null;
            count = 0;

        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public void Push(int el)
        {
            if (IsEmpty())
                Top = new Node(el);
            else
                Top = new Node(el, Top);


            count++;
        }
        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            int output = Top.data;
            Top = Top.next;
            count--;
            return output;


        }
        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return Top.data;


        }

    }
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        private int count;
        public Queue()
        {
            Front = Rear = null;
            count = 0;

        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public void Enqueue(int el)
        {
            if (IsEmpty())
                Front = Rear = new Node(el);
            else
                Rear = Rear.next = new Node(el);


            count++;
        }
        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            int output = Front.data;
            Front = Front.next;
            count--;
            return output;

        }
        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            return Front.data;

        }
    }


    
*/