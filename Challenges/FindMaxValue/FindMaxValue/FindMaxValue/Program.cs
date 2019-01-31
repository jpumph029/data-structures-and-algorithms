using System;
using System.Collections;
using Trees.Class;

namespace FindMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node = new Node(-1);
            node.LeftChild = new Node(-2);
            node.LeftChild.LeftChild = new Node(-31);
            node.LeftChild.RightChild = new Node(-4);
            node.RightChild = new Node(-5);
            node.RightChild.LeftChild = new Node(-6);
            node.RightChild.RightChild = new Node(-7);

            BinaryTree tree = new BinaryTree(node);
            FindMaxValue(tree);
        }
        /// <summary>
        /// Returns the largest value of a given BinaryTree
        /// </summary>
        /// <param name="binaryTree"></param>
        /// <returns></returns>
        public static int FindMaxValue(BinaryTree binaryTree)
        {
            try
            {
                Queue queue = new Queue();
                int MaxValue = binaryTree.Root.Value;
                if (binaryTree.Root != null)
                {
                    if (binaryTree.Root.LeftChild != null)
                    {
                        queue.Enqueue(binaryTree.Root.LeftChild);
                    }
                    if (binaryTree.Root.RightChild != null)
                    {
                        queue.Enqueue(binaryTree.Root.RightChild);
                    }
                    while (queue.Count > 0)
                    {
                        Object obj = queue.Dequeue();
                        Node node = obj as Node;

                        if (node.Value > MaxValue)
                        {
                            MaxValue = node.Value;
                        }
                        if (node.LeftChild != null)
                        {
                            queue.Enqueue(node.LeftChild);
                        }
                        if (node.RightChild != null)
                        {
                            queue.Enqueue(node.RightChild);
                        }
                    }
                }
                Console.WriteLine(MaxValue);
                return MaxValue;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }
            
    }
}
