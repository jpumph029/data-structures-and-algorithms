using System;
using LinkedList.Classes;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List();
            
            Console.ReadLine();
        }
        /// <summary>
        /// this prints a node and 7 more from a list, this also uses Includes to see if includes worked
        /// </summary>
        static void List()
        {
            Node node = new Node(4);
            Console.WriteLine($"Node node = new Node({node.Value});");

            LList list = new LList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.InsertBefore(1, 0);
            list.InsertAfter(7, 9);
            list.Append(22);

            Console.WriteLine($"Does 2 exist?: {list.Includes(2)}");
            Console.WriteLine($"Does 4 exist?: {list.Includes(4)}");
            list.Print();

        }
    }
}
