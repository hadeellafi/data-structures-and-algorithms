using System;

namespace data_structures_and_algorithms
{
    public class main
    {
        static void Main(string[] args)
        {
            //CC01
            /* int[] arr = { };
             int[] result = reverce(arr);
             Console.WriteLine(result != null ? string.Join(", ", result) : "null");*/

            
            //CC03
            /*
            int[] arr = { 0, 1, 2, 3, 4};
            Console.WriteLine(CC03.BinarySearch(arr,4));*/

            //CC05
            List list = new List();
            list.InsertEnd(2);
            list.InsertEnd(3);
            Console.WriteLine(list.IsInclude(3));
            Console.WriteLine(list.ToString());
        }

        public static int[] reverce(int[] arr)
        {
            if ( arr.Length > 0)
            {
                int[] r_arr = new int[arr.Length];
                int index = 0;
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    r_arr[index] = arr[i];
                    index++;
                }

                return r_arr;
            }
            return null;
        }
    }
}
