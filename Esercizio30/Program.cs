using Esercizio30;
/*Create your own Queue class. Let's call it MyQueue<T>. 
 * We want this to be generic, so we can allow the user to define what items need to be stored. 
 * Implement the following methods:
- Queue
- Dequeue
- Peek    */

var intQueue = new MyQueue<int>();
intQueue.Queue(1);
intQueue.Queue(2);
intQueue.Queue(3);

intQueue.Dequeue();


for (int i = 0; i < intQueue.GetItems().Length; i++)
{
    Console.WriteLine(intQueue.GetItems()[i]);
}

var stringQueue = new MyQueue<string>();
stringQueue.Queue("a");
stringQueue.Queue("b");
stringQueue.Queue("c");

stringQueue.Dequeue();


for (int i = 0; i < stringQueue.GetItems().Length; i++)
{
    Console.WriteLine(stringQueue.GetItems()[i]);
}