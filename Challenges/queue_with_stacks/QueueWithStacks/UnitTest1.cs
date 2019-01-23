using queue_with_stacks.Classes;
using System;
using Xunit;

namespace QueueWithStacks
{
    public class UnitTest1
    {
        [Fact]
        public void DoesEnqueueWork()
        {
            PseudoQueue pseudoQueue = new PseudoQueue();
            pseudoQueue.EnQueue(1);
            Assert.Equal(1, pseudoQueue.PQueue.Top.Value);
        }
        [Fact]
        public void DoesEnqueueWorkWithMultiple()
        {
            PseudoQueue pseudoQueue = new PseudoQueue();
            pseudoQueue.EnQueue(1);
            pseudoQueue.EnQueue(2);
            pseudoQueue.EnQueue(3);
            Assert.Equal(3, pseudoQueue.PQueue.Top.Value);
            Assert.Equal(2, pseudoQueue.PQueue.Top.Next.Value);
            Assert.Equal(1, pseudoQueue.PQueue.Top.Next.Next.Value);
        }
        [Fact]
        public void DoesEnqueueWorkWithNegative()
        {
            PseudoQueue pseudoQueue = new PseudoQueue();
            pseudoQueue.EnQueue(-1);
            Assert.Equal(-1, pseudoQueue.PQueue.Top.Value);
        }

    }
}
