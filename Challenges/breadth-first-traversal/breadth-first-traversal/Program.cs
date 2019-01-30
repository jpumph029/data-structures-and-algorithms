using System;
using System.Collections;
using Trees.Class;


namespace breadth_first_traversal
{
    public class Program
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
        public static string BreadthFirst(BinaryTree tree)
        {
            string result = ""; 

                Queue queue = new Queue();
                if (tree.Root != null)
                {
                    result += $"{tree.Root.Value} ";
                    Console.WriteLine($"{tree.Root.Value}");
                    if (tree.Root.LeftChild != null)
                    {
                        queue.Enqueue(tree.Root.LeftChild);
                    }
                    if (tree.Root.RightChild != null)
                    {
                        queue.Enqueue(tree.Root.RightChild);
                    }

                    while (queue.Count != 0)
                    {
                        Object obj = queue.Dequeue();
                        Node node = obj as Node;

                        Console.WriteLine($"{node.Value}");

                        result += $"{node.Value} ";

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
                return result;
            }
    }
}
