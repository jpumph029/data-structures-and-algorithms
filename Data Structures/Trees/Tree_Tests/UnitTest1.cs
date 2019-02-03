using System;
using Trees.Class;
using Xunit;

namespace Tree_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DoesAddWork()
        {
            BinarySearchTree tree = new BinarySearchTree();
            ;
            Assert.Equal(1, tree.Add(tree.Root, 1).Value);
        }
        [Fact]
        public void DoesAddAddCorrectly()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(tree.Root, 1);
            tree.Add(tree.Root, 2);
            tree.Add(tree.Root, 3);
            Assert.Equal(1, tree.Root.Value);
            Assert.Equal(2, tree.Root.RightChild.Value);
            Assert.Equal(3, tree.Root.RightChild.RightChild.Value);
        }
        [Fact]
        public void DoesAddAddCorrectlyIfTreeIsPopulated()
        {
            Node node = new Node(3);
            node.LeftChild = new Node(1);
            BinarySearchTree tree = new BinarySearchTree(node);
            tree.Add(tree.Root, 2);
            
            Assert.Equal(2, tree.Root.LeftChild.RightChild.Value);
        }
        [Fact]
        public void DoesContainWork()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(tree.Root, 1);
            Assert.True(tree.Contains(1));
        }
        [Fact]
        public void DoesContainWorkIfNodeDoesntExist()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(tree.Root, 1);
            Assert.False(tree.Contains(2));
        }
        [Fact]
        public void DoesContainWorkWithMultipleOtherNodesInATree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(tree.Root, 1);
            tree.Add(tree.Root, 2);
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 4);
            Assert.True(tree.Contains(2));
        }
        [Fact]
        public void DoesPreOrderWork()
        {
            Node node = new Node(1);
            node.LeftChild = new Node(2);
            node.LeftChild.LeftChild = new Node(3);
            node.LeftChild.RightChild = new Node(4);
            node.RightChild = new Node(5);
            node.RightChild.LeftChild = new Node(6);
            node.RightChild.RightChild = new Node(7);

            BinaryTree PreOrderTree = new BinaryTree(node);
            Assert.Equal(1, PreOrderTree.PreOrder(node)[0]);
            Assert.Equal(2, PreOrderTree.PreOrder(node)[1]);
            Assert.Equal(3, PreOrderTree.PreOrder(node)[2]);
            Assert.Equal(4, PreOrderTree.PreOrder(node)[3]);
            Assert.Equal(5, PreOrderTree.PreOrder(node)[4]);
            Assert.Equal(6, PreOrderTree.PreOrder(node)[5]);
            Assert.Equal(7, PreOrderTree.PreOrder(node)[6]);
        }
        [Fact]
        public void DoesPreOrderWorkWithNegatives()
        {
            Node node = new Node(-1);
            node.LeftChild = new Node(-2);
            node.LeftChild.LeftChild = new Node(-3);
            node.LeftChild.RightChild = new Node(-4);
            node.RightChild = new Node(-5);
            node.RightChild.LeftChild = new Node(-6);
            node.RightChild.RightChild = new Node(-7);

            BinaryTree PreOrderTree = new BinaryTree(node);
            Assert.Equal(-1, PreOrderTree.PreOrder(node)[0]);
            Assert.Equal(-2, PreOrderTree.PreOrder(node)[1]);
            Assert.Equal(-3, PreOrderTree.PreOrder(node)[2]);
            Assert.Equal(-4, PreOrderTree.PreOrder(node)[3]);
            Assert.Equal(-5, PreOrderTree.PreOrder(node)[4]);
            Assert.Equal(-6, PreOrderTree.PreOrder(node)[5]);
            Assert.Equal(-7, PreOrderTree.PreOrder(node)[6]);
        }
        [Fact]
        public void doesPreorderWorkWithNegativeAndPositiveNodes()
        {
            Node node = new Node(-1);
            node.LeftChild = new Node(2);
            node.LeftChild.LeftChild = new Node(-3);
            node.LeftChild.RightChild = new Node(4);
            node.RightChild = new Node(-5);
            node.RightChild.LeftChild = new Node(6);
            node.RightChild.RightChild = new Node(-7);

            BinaryTree PreOrderTree = new BinaryTree(node);
            Assert.Equal(-1, PreOrderTree.PreOrder(node)[0]);
            Assert.Equal(2, PreOrderTree.PreOrder(node)[1]);
            Assert.Equal(-3, PreOrderTree.PreOrder(node)[2]);
            Assert.Equal(4, PreOrderTree.PreOrder(node)[3]);
            Assert.Equal(-5, PreOrderTree.PreOrder(node)[4]);
            Assert.Equal(6, PreOrderTree.PreOrder(node)[5]);
            Assert.Equal(-7, PreOrderTree.PreOrder(node)[6]);
        }
        [Fact]
        public void DoesInOrderWork()
        {
            Node node = new Node(1);
            node.LeftChild = new Node(2);
            node.LeftChild.LeftChild = new Node(3);
            node.LeftChild.RightChild = new Node(4);
            node.RightChild = new Node(5);
            node.RightChild.LeftChild = new Node(6);
            node.RightChild.RightChild = new Node(7);

            BinaryTree InOrderTree = new BinaryTree(node);
            Assert.Equal(3, InOrderTree.InOrder(node)[0]);
            Assert.Equal(2, InOrderTree.InOrder(node)[1]);
            Assert.Equal(4, InOrderTree.InOrder(node)[2]);
            Assert.Equal(1, InOrderTree.InOrder(node)[3]);
            Assert.Equal(6, InOrderTree.InOrder(node)[4]);
            Assert.Equal(5, InOrderTree.InOrder(node)[5]);
            Assert.Equal(7, InOrderTree.InOrder(node)[6]);
        }
        [Fact]
        public void DoesInOrderWorkWithNegatives()
        {
            Node node = new Node(-1);
            node.LeftChild = new Node(-2);
            node.LeftChild.LeftChild = new Node(-3);
            node.LeftChild.RightChild = new Node(-4);
            node.RightChild = new Node(-5);
            node.RightChild.LeftChild = new Node(-6);
            node.RightChild.RightChild = new Node(-7);

            BinaryTree InOrderTree = new BinaryTree(node);
            Assert.Equal(-3, InOrderTree.InOrder(node)[0]);
            Assert.Equal(-2, InOrderTree.InOrder(node)[1]);
            Assert.Equal(-4, InOrderTree.InOrder(node)[2]);
            Assert.Equal(-1, InOrderTree.InOrder(node)[3]);
            Assert.Equal(-6, InOrderTree.InOrder(node)[4]);
            Assert.Equal(-5, InOrderTree.InOrder(node)[5]);
            Assert.Equal(-7, InOrderTree.InOrder(node)[6]);
        }
        [Fact]
        public void doesInOrderWorkWithNegativeAndPositiveNodes()
        {
            Node node = new Node(-1);
            node.LeftChild = new Node(2);
            node.LeftChild.LeftChild = new Node(-3);
            node.LeftChild.RightChild = new Node(4);
            node.RightChild = new Node(-5);
            node.RightChild.LeftChild = new Node(6);
            node.RightChild.RightChild = new Node(-7);

            BinaryTree InOrderTree = new BinaryTree(node);
            Assert.Equal(-3, InOrderTree.InOrder(node)[0]);
            Assert.Equal(2, InOrderTree.InOrder(node)[1]);
            Assert.Equal(4, InOrderTree.InOrder(node)[2]);
            Assert.Equal(-1, InOrderTree.InOrder(node)[3]);
            Assert.Equal(6, InOrderTree.InOrder(node)[4]);
            Assert.Equal(-5, InOrderTree.InOrder(node)[5]);
            Assert.Equal(-7, InOrderTree.InOrder(node)[6]);
        }

        [Fact]
        public void DoesPostOrderWork()
        {
            Node node = new Node(1);
            node.LeftChild = new Node(2);
            node.LeftChild.LeftChild = new Node(3);
            node.LeftChild.RightChild = new Node(4);
            node.RightChild = new Node(5);
            node.RightChild.LeftChild = new Node(6);
            node.RightChild.RightChild = new Node(7);

            BinaryTree PostOrderTree = new BinaryTree(node);
            Assert.Equal(2, PostOrderTree.PostOrder(node)[0]);
            Assert.Equal(3, PostOrderTree.PostOrder(node)[1]);
            Assert.Equal(4, PostOrderTree.PostOrder(node)[2]);
            Assert.Equal(5, PostOrderTree.PostOrder(node)[3]);
            Assert.Equal(6, PostOrderTree.PostOrder(node)[4]);
            Assert.Equal(7, PostOrderTree.PostOrder(node)[5]);
            Assert.Equal(1, PostOrderTree.PostOrder(node)[6]);
        }
        [Fact]
        public void DoesPostOrderWorkWithNegatives()
        {
            Node node = new Node(-1);
            node.LeftChild = new Node(-2);
            node.LeftChild.LeftChild = new Node(-3);
            node.LeftChild.RightChild = new Node(-4);
            node.RightChild = new Node(-5);
            node.RightChild.LeftChild = new Node(-6);
            node.RightChild.RightChild = new Node(-7);

            BinaryTree PostOrderTree = new BinaryTree(node);
            Assert.Equal(-2, PostOrderTree.PostOrder(node)[0]);
            Assert.Equal(-3, PostOrderTree.PostOrder(node)[1]);
            Assert.Equal(-4, PostOrderTree.PostOrder(node)[2]);
            Assert.Equal(-5, PostOrderTree.PostOrder(node)[3]);
            Assert.Equal(-6, PostOrderTree.PostOrder(node)[4]);
            Assert.Equal(-7, PostOrderTree.PostOrder(node)[5]);
            Assert.Equal(-1, PostOrderTree.PostOrder(node)[6]);
        }
        [Fact]
        public void doesPostOrderWorkWithNegativeAndPositiveNodes()
        {
            Node node = new Node(-1);
            node.LeftChild = new Node(2);
            node.LeftChild.LeftChild = new Node(-3);
            node.LeftChild.RightChild = new Node(4);
            node.RightChild = new Node(-5);
            node.RightChild.LeftChild = new Node(6);
            node.RightChild.RightChild = new Node(-7);

            BinaryTree PostOrderTree = new BinaryTree(node);
            Assert.Equal(2, PostOrderTree.PostOrder(node)[0]);
            Assert.Equal(-3, PostOrderTree.PostOrder(node)[1]);
            Assert.Equal(4, PostOrderTree.PostOrder(node)[2]);
            Assert.Equal(-5, PostOrderTree.PostOrder(node)[3]);
            Assert.Equal(6, PostOrderTree.PostOrder(node)[4]);
            Assert.Equal(-7, PostOrderTree.PostOrder(node)[5]);
            Assert.Equal(-1, PostOrderTree.PostOrder(node)[6]);
        }
    }
}
