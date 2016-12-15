using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class DynamicStack<T>:  DynamicArray<T>, IMyStack<T>
    {
        private int MaxSize = 79;

        public void Push(T toPushValue)
        {           

            if (Size < MaxSize)
            {
                Add(toPushValue);
            }
            else
            {
                Console.WriteLine("Buffer is Full");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public T Pop()
        {
            T temp;
            temp = Get(counter-1);
            Remove(counter-1);
            return temp;
        }

        public T Peek()
        {
            return Get(counter - 1);
        }
    }
}
