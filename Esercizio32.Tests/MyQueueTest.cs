namespace Esercizio32.Tests; 
using MyQueue;
using Xunit.Sdk;

public class MyQueueTest
{
    [Fact]
    public void Queue_ShouldAddsAnItemToList()
    {
        var myQueue = new MyQueue<int>();
        int itemToAdd = 24;

        myQueue.Queue(itemToAdd);
        int result = myQueue.GetItems().First(); 

        Assert.Equal(itemToAdd, result);
    }
    [Fact]
    public void Dequeue_ShouldRemovesFirstItemFromList()
    {
        var myQueue = new MyQueue<int>();
   
        myQueue.Queue(24);
        myQueue.Queue(26);
        myQueue.Dequeue();
        var result = myQueue.GetItems().First();

        Assert.Equal(26, result);       
    }
    [Fact]
    public void Peek_ShouldReturnTheFirstItemFromList()
    {
        var myQueue = new MyQueue<int>();
        int firstItem = 24;
        myQueue.Queue(firstItem);
        myQueue.Queue(26);
        int result = myQueue.Peek();

        Assert.Equal(firstItem, result);
    }
    [Fact]
    public void Dequeue_ThrowsExceptionDequeueAnEmptyList()
    {
        var myQueue = new MyQueue<int>();
        Action act = () => myQueue.Dequeue();
        Assert.Throws<ArgumentOutOfRangeException>(act);
    }
        

}