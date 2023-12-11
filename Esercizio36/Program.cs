using Esercizio36;
using MyQueue;
/*Change your queue so that it can log the operations to the Console. 
 * After you're done, does your class still conform to the Dependency Inversion principle?
 */

var logger = new ConsoleLogger();
var myQueue = new MyQueue<string>(logger);
var stringQueue = new StringQueue(logger);

myQueue.Queue("a");
myQueue.Queue("b");
myQueue.Queue("c");
myQueue.Queue("d");
myQueue.Dequeue();
myQueue.Peek();

stringQueue.Queue("a");
stringQueue.Queue("b");
stringQueue.Dequeue();
stringQueue.Peek();


