using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Class
{
    class BinaryTree
    {
        public Node Root = null;
        public List<int> List = new List<int>();

        public BinaryTree(Node node)
        {
            Root = node;
        }

        public BinaryTree()
        {

        }


        public int[] PreOrder(Node root)
        {
            try
            {
                List.Add(root.Value);
                if (root.LeftChild != null)
                {
                    PreOrder(root.LeftChild);
                }
                if (root.RightChild != null)
                {
                    PreOrder(root.RightChild);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return List.ToArray();
        }



    }
}
