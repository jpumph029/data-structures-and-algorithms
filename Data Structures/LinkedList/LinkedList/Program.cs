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

            Console.WriteLine($"Does 2 exist?: {list.Includes(2)}");
            Console.WriteLine($"Does 4 exist?: {list.Includes(4)}");
            list.Print();

        }
    }
}
