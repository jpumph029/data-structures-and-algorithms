using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Node
    {
        /// <summary>
        /// Node Value Property
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Next Node Property
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
