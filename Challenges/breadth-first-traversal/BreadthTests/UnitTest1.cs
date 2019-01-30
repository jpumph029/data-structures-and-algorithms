using System;
using Xunit;
using breadth_first_traversal;
using Trees.Class;


namespace BreadthTests
{
    public class UnitTest1
    {
        [Fact]
        public void DoesBreadthFirstBreathFirst()
        {
            Node node = new Node(1);
            node.LeftChild = new Node(2);
            node.LeftChild.LeftChild = new Node(3);
            node.LeftChild.RightChild = new Node(4);
            node.RightChild = new Node(5);
            node.RightChild.LeftChild = new Node(6);
            node.RightChild.RightChild = new Node(7);

            BinaryTree tree = new BinaryTree(node);
            Assert.Equal("1 2 5 3 4 6 7 ", Program.BreadthFirst(tree));
        }
        [Fact]
        public void DoesBreathFirstBreadthOne()
        {
            Node node = new Node(1);

            BinaryTree tree = new BinaryTree(node);
            Assert.Equal("1 ", Program.BreadthFirst(tree));
        }
        [Fact]
        public void DoesBreathFirstBreadthNone()
        {

            BinaryTree tree = new BinaryTree();
            Assert.Equal("", Program.BreadthFirst(tree));
        }
    }
}
