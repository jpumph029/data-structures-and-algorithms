using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;

        }

        /// <summary>
        /// Adds a node to a que.
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Removes a node from a queue
        /// </summary>
        /// <returns></returns>
        public Node Dequeu()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Peeks at the front node
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return Front;
        }



    }
}
