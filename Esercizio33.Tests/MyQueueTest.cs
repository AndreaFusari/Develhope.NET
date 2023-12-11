namespace Esercizio33.Tests
{
    using MyQueue;
    using System.Collections.Generic;
    using Xunit.Sdk;

    public class MyQueueTest : IDisposable
    {
        private readonly MyQueue<int> myQueue;

        public MyQueueTest()
        {
           this.myQueue = new MyQueue<int>();
        }
        [Fact]
        public void Queue_ShouldAddItemToList()
        {
            
            int itemToAdd = 24;

            this.myQueue.Queue(itemToAdd);
            int result = this.myQueue.Peek();

            Assert.Equal(itemToAdd, result);
        }
        [Fact]
        public void Dequeue_ShouldRemoveFirstItemFromList()
        {
            
            int itemToRemove = 24;
            this.myQueue.Queue(itemToRemove);
            this.myQueue.Queue(26);
            this.myQueue.Dequeue();
            var result = this.myQueue.Peek();

            Assert.Equal(26, result);
        }
        [Fact]
        public void Peek_ShouldReturnTheFirstItemFromList()
        {
            
           int firstItem = 24;
           this.myQueue.Queue(firstItem);
           this.myQueue.Queue(26);
           int result = this.myQueue.Peek();

            Assert.Equal(firstItem, result);
        }
        [Fact]
        public void Dequeue_ThrowsExceptionDequeueAnEmptyList()
        {
           
            Action act = () => this.myQueue.Dequeue();
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }

        public void Dispose(){}
    }
}