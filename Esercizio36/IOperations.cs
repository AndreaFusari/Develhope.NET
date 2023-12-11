using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio36
{
    public interface IOperations<T>
    {
        void Queue(T item);
        void Dequeue();
        T Peek();

    }
}
