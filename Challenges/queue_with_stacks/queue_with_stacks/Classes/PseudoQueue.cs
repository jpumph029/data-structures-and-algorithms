﻿using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace queue_with_stacks.Classes
{
    public class PseudoQueue
    {
        //Property
        public Stack PQueue { get; set; }
        //Constructor
        public PseudoQueue()
        {
            PQueue = new Stack();
        }
        /// <summary>
        /// Adds a node to PQueue Stack
        /// </summary>
        /// <param name="value"></param>
        public void EnQueue(int value)
        {
            PQueue.Push(value);
        }
        /// <summary>
        /// Removes nodes using a FIFO approach
        /// </summary>
        /// <returns></returns>
        public int DeQueue()
        {
            Stack stack = new Stack();
            Stack stack1 = new Stack();
            int temp;

            if (PQueue.Top.Next == null)
            {
                temp = PQueue.Pop().Value;
                return temp;
            }
            while (PQueue.Top.Next != null)
            {
                stack.Push(PQueue.Pop().Value);
            }

            temp = PQueue.Top.Value;

            while (stack.Top.Next != null)
            {
                stack1.Push(stack.Pop().Value);
            }
            if (stack.Top.Next == null)
            {
                stack1.Push(stack.Pop().Value);
            }
            temp = stack1.Top.Value;
            return temp;
        }

    }
}




        



    

