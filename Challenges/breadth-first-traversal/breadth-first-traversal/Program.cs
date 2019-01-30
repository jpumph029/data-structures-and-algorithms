using System;
using System.Collections;
using Trees.Class;


namespace breadth_first_traversal
{
    class Program
    {
        static void Main(string[] args)
        {

            Node node = new Node(1);
            node.LeftChild = new Node(2);
            node.LeftChild.LeftChild = new Node(3);
            node.LeftChild.RightChild = new Node(4);
            node.RightChild = new Node(5);
            node.RightChild.LeftChild = new Node(6);
            node.RightChild.RightChild = new Node(7);

            BinaryTree tree = new BinaryTree(node);
            BreadthFirst(tree);
        }
        public static void BreadthFirst(BinaryTree tree)
        {
            try
            {
                Queue queue = new Queue();
                if (tree.Root != null)
                {
                    Console.Write($"{tree.Root.Value}");
                    queue.Enqueue(tree.Root.LeftChild);
                    queue.Enqueue(tree.Root.RightChild);
                    while (queue != null)
                    {
                        Object obj = queue.Dequeue();
                        Node node = obj as Node;

                        Console.Write($"{node.Value}");

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
            }
            catch (Exception e)
            {

                Console.WriteLine($"\n{e.Message}");
            }
        }
    }
}
