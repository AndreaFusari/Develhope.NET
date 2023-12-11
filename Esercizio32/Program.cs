using MyQueue;

MyQueue<string> queue = new MyQueue<string>();

queue.Queue("a");
queue.Queue("b");
queue.Queue("c");

queue.Dequeue();

foreach (var item in queue.GetItems())
{
    Console.WriteLine(item);
}

