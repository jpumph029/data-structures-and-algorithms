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
        [Fact]
        public void CanPeakAtQeueu()
        {
            Node node = new Node(-12);
            Queue queue = new Queue(node);
 
            Assert.Equal(-12, queue.Peek().Value);
        }
        [Fact]
        public void CanPeakAtQeueuMore()
        {
            Node node = new Node(-12);
            Queue queue = new Queue(node);
            queue.Enqueue(-13);
            queue.Enqueue(-13);
            queue.Enqueue(-13);
            queue.Enqueue(-13);
            queue.Enqueue(-13);
            Assert.Equal(-12, queue.Peek().Value);
        }
        [Fact]
        public void CanPeakAtQeueuMorebutPositiveNumbers()
        {
            Node node = new Node(12);
            Queue queue = new Queue(node);
            queue.Enqueue(13);
            queue.Enqueue(13);
            queue.Enqueue(13);
            queue.Enqueue(13);
            queue.Enqueue(13);
            Assert.Equal(12, queue.Peek().Value);
        }
        [Fact]
        public void CanPush()
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.Equal(1, stack.Top.Value);
        }
        [Fact]
        public void CanPushMultiple()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.Equal(3, stack.Top.Value);
        }
        [Fact]
        public void CanPushNegatives()
        {
            Stack stack = new Stack();
            stack.Push(-1);
            Assert.Equal(-1, stack.Top.Value);
        }



    }
}
