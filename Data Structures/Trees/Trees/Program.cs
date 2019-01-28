using System;
using Trees.Class;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinarySearchTree tree = new BinarySearchTree();
            //tree.Add(tree.Root, 1);
            //tree.Add(tree.Root, 2);
            //tree.Add(tree.Root, 3);
            //tree.Add(tree.Root, 4);
            //tree.Add(tree.Root, 5);
            //tree.Add(tree.Root, 6);
            //Console.WriteLine($"Does 4 exist in the tree of 1-6? {tree.Contains(4)}");

            Node node = new Node(1);
            node.LeftChild = new Node(2);
            node.LeftChild.LeftChild = new Node(3);
            node.LeftChild.RightChild = new Node(4);
            node.RightChild = new Node(5);
            node.RightChild.LeftChild = new Node(6);
            node.RightChild.RightChild = new Node(7);

            BinaryTree BTree = new BinaryTree(node);

          
            foreach (int i in BTree.PreOrder(node))
            {
                Console.Write($"[{i}]");
            }
        }
    }
}
