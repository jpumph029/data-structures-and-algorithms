using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Class
{
    public class BinaryTree
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

        /// <summary>
        /// traverses the depth of a tree recursivly going Root, Left, Right then returning as an array.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
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

        /// <summary>
        /// traverses the depth of a tree recursivly going Left, Root, Right then returning as an array.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int[] InOrder(Node root)
        {
            try
            {
                if (root.LeftChild != null)
                {
                    InOrder(root.LeftChild);
                }

                List.Add(root.Value);

                if (root.RightChild != null)
                {
                    InOrder(root.RightChild);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return List.ToArray();
        }

        /// <summary>
        /// traverses the depth of a tree recursivly going Left, Right, Root then returning as an array.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int[] PostOrder(Node root)
        {
            try
            {
                if (root.LeftChild != null)
                {
                    PreOrder(root.LeftChild);
                }
                if (root.RightChild != null)
                {
                    PreOrder(root.RightChild);
                }
                List.Add(root.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return List.ToArray();
        }



    }
}
