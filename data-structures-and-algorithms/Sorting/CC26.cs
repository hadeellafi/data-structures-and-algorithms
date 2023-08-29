using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.Sorting
{
    public class CC26
    {

       public void Insert(int[] sorted, int value,int sizeOfSorted)
        {
            int i = 0;
            while (i < sizeOfSorted && value > sorted[i])
            {
                i++;
            }
            while (i < sizeOfSorted)
            {
                int temp = sorted[i];
                sorted[i] = value;
                value = temp;
                i++;
            }
            sorted[sizeOfSorted] = value;
        }

        public int[] InsertionSort(int[] input)
        {
            int[] sorted = new int[input.Length];
            sorted[0] = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                Insert(sorted, input[i],i);
            }
            return sorted;
        }


    }
}
