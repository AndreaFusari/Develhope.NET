using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio30
{
    public class MyQueue<T>
    {
        private T[] items;
        private int index;

        public MyQueue()
        {
            items = new T[1];
        }

        public void Queue(T item)

        {
            if (index == items.Length)
            {
                Array.Resize(ref items, items.Length + 1);
            }
            this.items[index] = item;

            this.index++;

        }

        public void Dequeue()
        {
            if (index == -1)
            {
                throw new IndexOutOfRangeException("La coda è vuota");
            }
            items = items.Reverse().ToArray();

            Array.Resize(ref items, this.items.Length - 1);

            items = items.Reverse().ToArray();

            this.index--;

        }

        public T Peek()
        {
            return items[0];
        }

        public T[] GetItems() 
        { 
            return items; 
        }

    }
}
