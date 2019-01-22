using System;
using Xunit;

using StacksAndQueues;
using StacksAndQueues.Classes;

namespace StacksAndQueues_Tests
{
    public class UnitTest1
    {
     [Fact]
     public void CanQueue()
        {
            Node node = new Node(1);
            Queue queue = new Queue(node);

            queue.Enqueue(1);
            Assert.Equal(1, queue.Rear.Value);
        }
        [Fact]
        public void CanQueueMultiple()
        {
            Node node = new Node(1);
            Queue queue = new Queue(node);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.Equal(3, queue.Rear.Value);
        }
        [Fact]
        public void CanQueueMultipleWithNegatives()
        {
            Node node = new Node(1);
            Queue queue = new Queue(node);

            queue.Enqueue(-1);
            queue.Enqueue(-2);
            queue.Enqueue(-3);
            Assert.Equal(-3, queue.Rear.Value);
        }
        [Fact]
        public void CanDequeue()
        {
            Node node = new Node(1);
            Queue queue = new Queue(node);

            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Dequeu();
            Assert.Equal(12, queue.Front.Value);
        }
        [Fact]
        public void CanDequeueMultiple()
        {
            Node node = new Node(1);
            Queue queue = new Queue(node);

            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(14);
            queue.Dequeu();
            queue.Dequeu();
            Assert.Equal(13, queue.Front.Value);
        }
        [Fact]
        public void CanDequeueNegatives()
        {
            Node node = new Node(1);
            Queue queue = new Queue(node);

            queue.Enqueue(-12);
            queue.Enqueue(-13);
            queue.Dequeu();
            Assert.Equal(-12, queue.Front.Value);
        }



    }
}
