
using LinkedList.Classes;
using ll_kth_from_end;
using System;
using Xunit;

namespace ll_kth_from_end_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ChatchesException()
        {
            LList list = new LList();
            Assert.Throws<System.NullReferenceException>(() => Program.KthFromEnd(3, list));
        }
        [Fact]
        public void CanGetValueFromKth()
        {
            LList list = new LList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);


            Assert.Equal(4, Program.KthFromEnd(3, list));
        }
        [Fact]
        public void CanGetFirstValueFromKth()
        {
            LList list = new LList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);


            Assert.Equal(1, Program.KthFromEnd(0, list));
        }

    }
}
