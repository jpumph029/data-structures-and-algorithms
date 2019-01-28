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
            Console.WriteLine($"Does 4 exist in the tree of 1-6? {tree.Contains(4)}");
        }
    }
}
