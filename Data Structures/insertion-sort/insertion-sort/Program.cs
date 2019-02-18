using System;

namespace insertion_sort
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    public static int[] InsertionSort(int[] inputArr)
    {
            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArr[j - 1] > inputArr[j])
                    {
                    int temp = inputArr[j - 1];
                    inputArr[j - 1] = inputArr[j];
                    inputArr[j] = temp;
                    }
                }
            }
        return inputArr;
    }
    }
}
