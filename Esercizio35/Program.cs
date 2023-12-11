using MyQueue;
using Esercizio35;

// principio Liskov substitution e interface segregation mi sembrano rispettati

MyQueue<int> intQueue = new IntQueue();
MyQueue<string> stringQueue = new StringQueue();

stringQueue.Queue("Hello");
stringQueue.Queue("string");
stringQueue.Queue("");
stringQueue.Peek();

intQueue.Queue(1);
intQueue.Queue(2);
intQueue.Queue(3);
intQueue.Dequeue();





