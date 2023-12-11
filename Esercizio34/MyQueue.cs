
namespace MyQueue;
public class MyQueue<T> // Mi sembra conforme sia al primo che al secondo principio SOLID senza doverlo modificare
{
    private readonly List<T> items;

    public MyQueue()
    {
        items = [];
    }

    public T Peek()
    {
        Console.WriteLine($"Il primo elemento della queue è {items.ElementAt(0)}");
        return items[0];
    }


    public void Dequeue()
    {
        Console.WriteLine($"Rimosso elemento '{items.ElementAt(0)}'");
        items.RemoveAt(0);
    }

    public void Queue(T item)
    {
        items.Add(item);
        Console.WriteLine($"Aggiunto elemento {item}");
    }

}


