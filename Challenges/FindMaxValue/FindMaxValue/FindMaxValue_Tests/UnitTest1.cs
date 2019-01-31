using FindMaxValue;
using System;
using Trees.Class;
using Xunit;

namespace FindMaxValue_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DoesFindMaxFindMax()
        {
            Node node = new Node(1);
            node.LeftChild = new Node(2);
            node.LeftChild.LeftChild = new Node(31);
            node.LeftChild.RightChild = new Node(4);
            node.RightChild = new Node(5);
            node.RightChild.LeftChild = new Node(6);
            node.RightChild.RightChild = new Node(7);

            BinaryTree tree = new BinaryTree(node);
            Assert.Equal(31, Program.FindMaxValue(tree));
        }
        [Fact]
        public void DoesFindMaxFindMaxWithNegatives()
        {
            Node node = new Node(-1);
            node.LeftChild = new Node(-2);
            node.LeftChild.LeftChild = new Node(-31);
            node.LeftChild.RightChild = new Node(-4);
            node.RightChild = new Node(-5);
            node.RightChild.LeftChild = new Node(-6);
            node.RightChild.RightChild = new Node(-7);

            BinaryTree tree = new BinaryTree(node);
            Assert.Equal(-1, Program.FindMaxValue(tree));
        }
        [Fact]
        public void DoesFindMaxFindMaxWithOnlyANode()
        {
            Node node = new Node();

            BinaryTree tree = new BinaryTree(node);
            Assert.Equal(0, Program.FindMaxValue(tree));
        }
    }
}
