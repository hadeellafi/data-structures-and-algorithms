using System;


namespace data_structures_and_algorithms
{
    public class PseudoQueue
    {
        private Stack stack1,stack2;
        public PseudoQueue()
        {
            stack1 = new Stack();
            stack2 = new Stack();
        }
        public void Enqueue(int value)
        {
            while (!stack1.IsEmpty())
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(value);

            while (!stack2.IsEmpty())
            {
                stack1.Push(stack2.Pop());
            }
        }
        public int Dequeue() 
        { 
            return stack1.Pop();
        }
        public bool IsEmpty()
        {
            return stack1.IsEmpty();
        }
    }
}
