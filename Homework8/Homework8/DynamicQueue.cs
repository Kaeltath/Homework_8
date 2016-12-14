using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class DynamicQueue<T> : DynamicArray<T>, IMyQueue<T> 
    {

        public void Enqueue(T ElementToEnqueue)
        {
            Add(ElementToEnqueue);
        }

        public T Dequeue()
        {
            T temp = Get(0);
            Remove(0);
            return temp;
        }
    }
}
