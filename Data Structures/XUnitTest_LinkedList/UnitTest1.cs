using System;
using Xunit;
using LinkedList.Classes;

namespace XUnitTest_LinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void CanInsert0()
        {
            LList list = new LList();
            Assert.Equal(0, list.Insert(0));
        }
        [Fact]
        public void CanInsert1()
        {
            LList list = new LList();
            Assert.Equal(1, list.Insert(1));
        }
        [Fact]
        public void CanInsert7()
        {
            LList list = new LList();
            Assert.Equal(7, list.Insert(7));
        }
        [Fact]
        public void CanInclude0()
        {
            LList list = new LList();
            list.Insert(0);
            Assert.True(list.Includes(0));
        }
        [Fact]
        public void CanInclude1()
        {
            LList list = new LList();
            list.Insert(1);
            Assert.True(list.Includes(1));
        }
        [Fact]
        public void CanInclude7()
        {
            LList list = new LList();
            list.Insert(7);
            Assert.True(list.Includes(7));
        }
        [Fact]
        public void NodeIsNode()
        {
            Node node = new Node(4);
            Assert.Equal(4, node.Value);
        }
        [Fact]
        public void CanPrintAll()
        {
            LList list = new LList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            Assert.True(list.Print());
        }
        [Fact]
        public void CanPrintOne()
        {
            LList list = new LList();
            list.Insert(1);
            Assert.True(list.Print());
        }
    }
}
