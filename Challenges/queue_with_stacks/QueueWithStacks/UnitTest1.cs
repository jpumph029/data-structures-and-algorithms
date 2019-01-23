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
            Assert.Equal(1, pseudoQueue.PQueue.Top.Value);
        }
    }
}
