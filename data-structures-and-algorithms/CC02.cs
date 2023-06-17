using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class CC02Base
    {
        public static int[] insertShiftArray(int[] arr, int inputNum)
        {
            int[] newArr = new int[arr.Length + 1];
            int indexOfCenter =newArr.Length / 2;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < indexOfCenter)
                    newArr[i] = arr[i];
                else if (i == indexOfCenter)
                    newArr[i] = inputNum;
                else
                    newArr[i] = arr[i - 1];
            }
            return newArr;
        }
        public static int[] removeShiftArray(int[] arr)
        {
            int[] newArr = new int[arr.Length - 1];
            int indexOfCenter = arr.Length / 2;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < indexOfCenter)
                    newArr[i] = arr[i];
                else
                    newArr[i] = arr[i + 1];
            }
            return newArr;
        }

    }
}
