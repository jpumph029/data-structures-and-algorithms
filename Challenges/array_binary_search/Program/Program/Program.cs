using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 8, 15, 16, 23, 42 };
            int key = 2;
            int val = BinarySearch(array, key);
            Console.WriteLine(val);
            Console.Read();
        }

        public static int BinarySearch(int[] array, int key)
        {

            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {


                int mid = (min + max) / 2;

                if (array[mid] == key) return mid;

                else if (array[mid] < key) min = mid + 1;

                else if (array[mid] > key) max = mid - 1;


            }


            return -1;
        }
    }
}
