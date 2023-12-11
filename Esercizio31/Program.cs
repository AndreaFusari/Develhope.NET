
using System.Collections;
using MyQueue;

MyQueue<string> queue = new MyQueue<string>();
queue.Queue("a");
queue.Queue("b");
queue.Queue("c");
queue.Queue("d");
queue.Queue("e");
queue.Queue("f");
queue.Queue("g");
queue.Queue("h");
queue.Peek();
queue.Dequeue();
queue.Peek();
queue.Dequeue();
queue.Peek();

namespace MyQueue
{
    public class MyQueue<T> /*2 warning risolti
                             * CA1711: Gli identificatori non devono contenere un suffisso non corretto -> silenziato
                             * CA1050: Dichiarare i tipi negli spazi dei nomi -> To fix a violation of this rule, place the type in a namespace. */
    {
        private readonly List<T> items;

        public MyQueue()
        {
            items = new List<T>();
        }


        public void Queue(T item)
        {
            items.Add(item);
            Console.WriteLine($"Aggiunto elemento {item}");
        }

        public void Dequeue()
        {

            items.Remove(items.ElementAt(0));

        }
        public T Peek()
        {
            Console.WriteLine($"Il primo elemento della queue è {items.ElementAt(0)}");
            return items[0];
        }
    }



}
