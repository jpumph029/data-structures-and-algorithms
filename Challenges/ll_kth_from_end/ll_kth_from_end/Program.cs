using System;
using LinkedList.Classes;

namespace ll_kth_from_end
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList list = new LList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);

            KthFromEnd(3, list);
        }
        /// <summary>
        /// Finds the Kth node from the end of end a linked list and returns the kth nodes value.
        /// </summary>
        /// <param name="k"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int KthFromEnd(int k, LList list)
        {

            try
            {
                Node temp = list.Head;
                Node Current = list.Head;
                int counter = 0;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                    counter++;

                }
                Current = list.Head;
                for (int i = 0; i < counter - k; i++)
                {
                    Current = Current.Next;
                }
                list.Print();
                Console.WriteLine($"K: {k}\nNode : {Current.Value}");
                return Current.Value;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
