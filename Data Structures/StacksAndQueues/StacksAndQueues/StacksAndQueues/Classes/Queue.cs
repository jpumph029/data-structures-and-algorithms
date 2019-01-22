using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;

        }
    }
}
