using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Class
{
    class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node node)
        {
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                Add(Root, node.Value);
            }
        }
        public BinarySearchTree()
        {

        }
            
        public Node Add(Node root, int value)
        {
            try
            {
                Node node = new Node(value);
                if (Root == null)
                {
                    Root = node;
                    return node;
                }

                Node next = null;

                while (root != null)
                {
                    next = root;
                    if (value < root.Value)
                    {
                        root = root.LeftChild;
                    }
                    else
                    {
                        root = root.RightChild;
                    }
                }
                if (value <= next.Value)
                {
                    next.LeftChild = node;
                }
                else
                {
                    next.RightChild = node;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return root;
        }

        public bool Contains(int value)
        {
            try
            {
                if (Root.Value == value) { return true; }

                while (Root != null)
                {
                    if (Root.Value == value)
                    {
                        return true;
                    }
                    else if (value < Root.Value)
                    {
                        Root = Root.LeftChild;
                    }
                    else if (value > Root.Value)
                    {
                        Root = Root.RightChild;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
    }
}
