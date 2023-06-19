using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class CC03
    {
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int m = (left + right) / 2;
                if (target == arr[m])
                    return m;
                else if (arr[m] > target)
                    right = m - 1;
                else
                    left = m + 1;
            }

            return -1;
        }
    }
}

/*
 Recurion :
 public static int BinarySearch(int left, int right, int target, int[] arr)
        {
            if (left <= right)
            {
                int m = (left + right) / 2;
                if (target == arr[m])
                    return m;
                else if (arr[m] > target)
                    return BinarySearch(left, m - 1, target, arr);
                else
                    return BinarySearch(m + 1, right, target, arr);
            }
            else
                return -1;
        }
*/
