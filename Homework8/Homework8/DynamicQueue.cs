using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class DynamicQueue<T> : DynamicArray<T>, IMyQueue<T> 
    {
        private int MaxSize = 39;

        public void Enqueue(T ElementToEnqueue)
        {
            if (Size < MaxSize)
            {
                Add(ElementToEnqueue);
            }
            else 
            {
                Console.WriteLine("Buffer is Full");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public T Dequeue()
        {
            T temp = Get(0);
            Remove(0);
            return temp;
        }
    }
}
