
using data_structures_and_algorithms;

namespace CodeChallengesTests
{
    public class test11
    {

        [Fact]
        public void TestEnqueueIntoQueue()
        {
            PseudoQueue queue = new();

            queue.Enqueue(10);

            Assert.Equal(10, queue.Dequeue());
        }

        [Fact]
        public void TestDequeueFromPseudoQueue()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);


            Assert.Equal(10, queue.Dequeue());
            Assert.Equal(20, queue.Dequeue());
        }

        
        [Fact]
        public void TestEmpty_PseudoQueue_MultipleDequeues()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void TestDequeueOnEmptyQueueThrowException()
        {
            PseudoQueue queue = new PseudoQueue();

            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

       
    }
}
