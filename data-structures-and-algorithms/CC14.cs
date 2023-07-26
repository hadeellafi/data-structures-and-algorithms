using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class MaxStack
    {

        private List<int> baseStack;
        private List<int> maxStack;
        public MaxStack()
        {
            baseStack = new List<int>();
            maxStack = new List<int>();
        }
        public void Push(int value)
        {
            if (maxStack.Count == 0 || value >= maxStack[maxStack.Count - 1])
            {
                maxStack.Add(value);
            }
            baseStack.Add(value);
        }
        public void Pop()
        {
            if (baseStack.Count>0)
            {
                int poppedValue = baseStack[baseStack.Count - 1];
                baseStack.RemoveAt(baseStack.Count - 1);
                if (poppedValue == maxStack[maxStack.Count - 1])
                {
                    maxStack.RemoveAt(maxStack.Count - 1);
                }
            }
            else
                throw new InvalidOperationException("Cannot pop from an empty stack.");
        }
        public int GetMax()
        {
            if (maxStack.Count > 0)
            {
                return maxStack[maxStack.Count - 1];
            }
            throw new InvalidOperationException("Stack is empty.");
        }
    }

}


