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
    }
}
