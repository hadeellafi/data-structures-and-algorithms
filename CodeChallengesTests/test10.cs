using data_structures_and_algorithms;


namespace CodeChallengesTests
{
    public class test10
    {
        [Fact]
        public void TestPushStack()
        {
            Stack test =new Stack();
            test.Push(1);

            Assert.Equal(1, test.Peek());
        }
        [Fact]
        public void TestPushMultiIntoStack()
        {
            Stack test = new Stack();
            test.Push(1);
            test.Push(2);
            test.Push(3);

            Assert.Equal(3, test.Peek());
            

        }
        [Fact]
        public void TestPopOffStack()
        {
            Stack test = new Stack();
            test.Push(1);
            test.Push(2);
            test.Push(3);

            Assert.Equal(3, test.Pop());
            Assert.Equal(2, test.Peek());


        }
        [Fact]
        public void TestPopReachEmptyStack()
        {
            Stack test = new Stack();
            test.Push(1);
            test.Push(2);

            test.Pop();
            test.Pop();

            Assert.True(test.IsEmpty());


        }
        [Fact]
        public void TestPeekStack()
        {
            Stack test = new Stack();
            test.Push(1);
            test.Push(2);


            Assert.Equal(2,test.Peek());


        }

        [Fact]
        public void TestInstantiateEmptyStack()
        {
            Stack test = new Stack();

            Assert.True(test.IsEmpty());

        }
        [Fact]
        public void TestPeekOnEmptyStackThrowException()
        {
            Stack test = new Stack();

            Assert.Throws<InvalidOperationException>(() => test.Peek());
        }
        [Fact]
        public void TestPopOnEmptyStackThrowException()
        {
            Stack test = new Stack();

            Assert.Throws<InvalidOperationException>(() => test.Pop());
        }
        ///////////queue tests

        [Fact]
        public void TestEnqueueIntoQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(10);

            Assert.Equal(10,queue.Peek());
        }

        [Fact]
        public void TestEnqueueMultipleIntoQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Assert.True(!queue.IsEmpty());
            Assert.Equal(10, queue.Peek());
        }

        [Fact]
        public void TestDequeueFromQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);


            Assert.Equal(10, queue.Dequeue());
            Assert.Equal(20, queue.Peek());
        }

        [Fact]
        public void TestPeekQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Assert.Equal(10, queue.Peek());
        }

        [Fact]
        public void TestEmptyQueueMultipleDequeues()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void TestInstantiateEmptyQueue()
        {
            Queue queue = new Queue();

            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void TestDequeueOnEmptyQueueThrowException()
        {
            Queue queue = new Queue();

            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

        [Fact]
        public void TestPeekOnEmptyQueueThrowException()
        {
            Queue queue = new Queue();

            Assert.Throws<InvalidOperationException>(() => queue.Peek());
        }
    }

}

/*
*/
