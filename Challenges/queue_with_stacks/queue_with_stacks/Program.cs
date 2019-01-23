using queue_with_stacks.Classes;
using StacksAndQueues.Classes;
using System;

namespace queue_with_stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PseudoQueue pseudoQueue = new PseudoQueue();
            pseudoQueue.EnQueue(1);
            pseudoQueue.EnQueue(2);
            pseudoQueue.EnQueue(3);
            pseudoQueue.DeQueue();
            pseudoQueue.DeQueue();

        }
    }
}
