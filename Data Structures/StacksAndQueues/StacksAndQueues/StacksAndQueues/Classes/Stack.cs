using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Stack Constrictor with one Node
        /// </summary>
        /// <param name="node"></param>
        public Stack (Node node)
        {
            Top = node;
        }
        /// <summary>
        /// Empty Stack Constructor 
        /// </summary>
        public Stack()
        {
        }
        /// <summary>
        /// Pushes a node to a stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Pops a node off a stack
        /// </summary>
        /// <returns></returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }
         
        /// <summary>
        /// Peeks at the top of the stack
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
