using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class CC13
    {
       public bool ValidateBrackets(string input)
        {
            Stack<char> inputs = new Stack<char>();
            foreach (char c in input)
            {
                if (c == '{' || c == '(' || c == '[')
                {
                    inputs.Push(c);
                }
                else
                {
                    switch (c)
                    {
                        case ')':
                            if (inputs.Count > 0 && inputs.Peek() == '(')
                                inputs.Pop();
                            
                            else
                                return false;
                            
                            break;
                        case '}':
                            if (inputs.Count > 0 && inputs.Peek() == '{')

                                inputs.Pop(); 
                            
                            else
                            
                                return false;
                            
                            break;
                        case ']':
                            if (inputs.Count > 0 && inputs.Peek() == '[')
                            {
                                inputs.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                    }
                }
            }
            return inputs.Count == 0;
        }
    }
}
