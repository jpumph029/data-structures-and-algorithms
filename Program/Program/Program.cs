using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 6, 7, 8 };
            int value = 5;
            int[] newArr = ArrayInsert(array, value);
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write($"{newArr[i]}, ");
            }
            Console.WriteLine();
        }


        public static int[] ArrayInsert(int[] array, int value)
        {
            int[] newArr = new int[array.Length + 1];
            double arrLen = array.Length;
            double mid = arrLen / 2;
            int midFixed = Convert.ToInt32(Math.Ceiling(mid));

            for (int i = 0; i < newArr.Length; i++)
            {
                //our if conditions
                if (i == midFixed) newArr[i] = value;
                else if (i > midFixed) newArr[i] = array[i - 1];
                else newArr[i] = array[i];
            }
            return newArr;
        }
    }
}
