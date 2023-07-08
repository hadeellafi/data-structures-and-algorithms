using System;
using System.Collections;
using System.Collections.Generic;

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

            //5 & 6 & 7
            /*
             List list = new List();
             list.InsertEnd(1);
             list.InsertEnd(3);
             list.InsertEnd(1);
             list.InsertEnd(2);
             Console.WriteLine(list.ToString());

             try
             {
                 Console.WriteLine(list.kthFromEnd(0));

                 Console.WriteLine(list.kthFromEnd(-1));

                 Console.WriteLine(list.kthFromEnd(2));

                 Console.WriteLine(list.kthFromEnd(3));

                 Console.WriteLine(list.kthFromEnd(4));

             }
             catch (InvalidOperationException e)
             {
                 Console.WriteLine(e.Message);
             }
             catch(ArgumentException e)
             {
                 Console.WriteLine(e.Message);
             }
             */

            //lab 8

            List list1 = new List();
            List list2 = new List();    

            list1.InsertEnd(1);
            list1.InsertEnd(2);
            list1.InsertEnd(3);

            list2.InsertEnd(4);
            list2.InsertEnd(5);
            list2.InsertEnd(6);

            List zipList = new List();
            zipList= zipList.zipLists(list1 ,list2);
            Console.WriteLine(zipList.ToString());

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
