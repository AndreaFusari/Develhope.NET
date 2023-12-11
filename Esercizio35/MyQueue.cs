using Esercizio35;
namespace MyQueue;
public class MyQueue<T> : IOperations<T>
{
    private readonly List<T> items;

    public MyQueue()
    {
        items = [];
    }

    public void Queue(T item)
    {
        items.Add(item);
        Console.WriteLine($"Aggiunto elemento {item}");
    }

    public void Dequeue()
    {

        items.RemoveAt(0);
    }

    public T Peek()
    {
        Console.WriteLine($"Il primo elemento della queue è {items.ElementAt(0)}");
        return items[0];
    }
}


