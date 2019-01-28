using System;
using Trees.Class;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(tree.Root, 1);
            tree.Add(tree.Root, 2);
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 4);
            tree.Add(tree.Root, 5);
            tree.Add(tree.Root, 6);
            Console.WriteLine($"Does the tree contain 6 {tree.Contains(6)}");
     


            Node node = new Node(1);
            node.LeftChild = new Node(2);
            node.LeftChild.LeftChild = new Node(3);
            node.LeftChild.RightChild = new Node(4);
            node.RightChild = new Node(5);
            node.RightChild.LeftChild = new Node(6);
            node.RightChild.RightChild = new Node(7);

            BinaryTree PreOrderTree = new BinaryTree(node);
            BinaryTree InOrderTree = new BinaryTree(node);
            BinaryTree PostOrderTree = new BinaryTree(node);


            Console.WriteLine("PreOrder:");
            foreach (int i in PreOrderTree.PreOrder(node))
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine("\nInOrder:");
            foreach (int i in InOrderTree.InOrder(node))
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine("\nPostOrder:");
            foreach (int i in PostOrderTree.PostOrder(node))
            {
                Console.Write($"[{i}]");
            }
        }
    }
}
