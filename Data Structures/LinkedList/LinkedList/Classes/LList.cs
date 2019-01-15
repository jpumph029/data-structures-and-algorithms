using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        /// <summary>
        /// The first node.
        /// </summary>
        public Node Head { get; set; }
        /// <summary>
        /// The current node.
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// Insert a node into a list
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
            return value;
        }
        /// <summary>
        /// Method to see if a node is included in a list
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }
                return false;
        }
        /// <summary>
        /// Appends a node to the LL
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            while(Current.Next != null)
            {
                Current = Current.Next;
            }
            Node node = new Node(value);
            Current.Next = node;
        }
        /// <summary>
        /// Inserts a new node before a given value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newValue"></param>
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;
            if (Current.Value == value)
            {
                Insert(newValue);
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Next.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Insert a new node after a value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newValue"></param>
        public void InsertAfter(int value, int newValue)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }
        }
        /// <summary>
        /// Prints all nodes in a list
        /// </summary>
        /// <returns></returns>
        public bool Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} => ");
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
            return true;
        }

    }
}
