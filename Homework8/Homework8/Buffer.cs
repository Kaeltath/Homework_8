using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    abstract class Buffer<T> : IBuffer<T>
        {
            protected T[] dynamicArray = new T[5];
            protected int counter = 0;
            protected int _capacity = 5;

            public bool IsFull() 
            {
                if (counter > _capacity)
                {
                    return true;
                }

                return false;
            }

            public bool IsEmpty()
            {
                if (counter == 0)
                {
                    return true;
                }

                return false;
            }

            public void Print()
            {
                string test;
                test = dynamicArray[0] as string;
                if (test == string.Empty)
                {
                    Console.WriteLine("String is empty");
                }
                else
                {
                    foreach (T i in dynamicArray)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine();
                }
            }
      }
}

