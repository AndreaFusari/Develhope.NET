using Esercizio36;

namespace MyQueue;
public class MyQueue<T> : IOperations<T>
{
    private readonly List<T> items;
    private readonly ILogger logger;

    public MyQueue(ILogger logger)
    {
        items = [];
        this.logger = logger;
    }

    public void Queue(T item)
    {
       items.Add(item);
       logger.Info($"Added: {item}");

    }

    public void Dequeue()
    {
        T removedItem = items[0];
        logger.Info($"Removed : {removedItem}");
        items.RemoveAt(0);
    }

    public T Peek()
    {
        T peekedItem = items[0];
        logger.Info($"Peeked: {peekedItem}");
        return peekedItem;
    }
}


