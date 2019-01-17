using System;
using LinkedList.Classes;

namespace ll_merge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");




            LList list = new LList();
            list.Insert(1);
            list.Insert(3);
            list.Insert(5);
            list.Insert(7);

            LList listB = new LList();
            listB.Insert(2);
            listB.Insert(4);
            listB.Insert(6);
            listB.Insert(8);
            listB.Insert(10);

            list.Print();
            MergeTwoLinkedList(list, listB);
            list.Print();
  
        }

        /// <summary>
        /// Takes two Linked Lists and "Zips" them together
        /// </summary>
        /// <param name="list"></param>
        /// <param name="listB"></param>
        /// <returns>list</returns>
        static LList MergeTwoLinkedList(LList list, LList listB)
        {
            list.Current = list.Head;
            listB.Current = listB.Head;

            Node nodeA = list.Current.Next;
            Node nodeB = listB.Head;

            list.Current = list.Head;
            listB.Current = listB.Head;

            while (nodeA != null && nodeB != null)
            {

                list.Current.Next = listB.Current;
                list.Current.Next = nodeA;

                list.Current = nodeA;
                listB.Current = nodeB;

                if (list.Current != null) nodeA = list.Current.Next;
                if (listB.Current != null) nodeB = listB.Current.Next;

            }
    

            list.Current = list.Head;

            return list;
        }
    }
}
