namespace data_structures_and_algorithms
{
    public class CC01
    {
        static void Main(string[] args)
        {

        }
        public static int[] reverce(int[] arr)
        {
            if (arr.Length > 0)
            {
                int index = 0;
                int[] r_arr = new int[arr.Length];
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    r_arr[index] = arr[i];
                    index++;
                }

                return r_arr;
            }
            return arr;
        }
    }
}