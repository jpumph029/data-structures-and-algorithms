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
        /// Prints all nodes in a list
        /// </summary>
        /// <returns></returns>
        public bool Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
            return true;
        }

    }
}
