using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class DynamicArray<T> : Buffer<T>
    {
        private int maxBufferSize = 100;
        private int minBufferSize = 5;

        protected void Add(T element) 
        {
            counter++;
            if (IsFull()) 
            {
                _capacity = _capacity * 2;
                if (_capacity < maxBufferSize)
                {
                    T[] tempArray = new T[_capacity];
                    for (int i = 0; i < dynamicArray.Length; i++)
                    {
                        tempArray[i] = dynamicArray[i];
                    }
                    dynamicArray = tempArray;
                    dynamicArray[counter - 1] = element;
                }
                else 
                {
                    Console.WriteLine("Stack Overflow");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            dynamicArray[counter-1] = element;            
        }

        public void Insert(T element, int index) 
        {
            counter++;           
            if (IsFull())
            {
                _capacity = _capacity * 2;
                if (_capacity < maxBufferSize)
                {
                    T[] tempArray = new T[_capacity];
                    for (int i = 0; i < dynamicArray.Length; i++)
                    {
                        tempArray[i] = dynamicArray[i];
                    }
                    dynamicArray = tempArray;

                    for (int k = counter; k >= index; k--)
                    {
                        dynamicArray[k] = dynamicArray[k - 1];
                    }
                    dynamicArray[index] = element;
                }
                else 
                {
                    Console.WriteLine("Stack Overflow");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }
            
            for (int k = counter; k >= index; k--)
            {
                dynamicArray[k] = dynamicArray[k-1];
            }
            dynamicArray[index] = element;

        }

        protected T Get(int index) 
        {
            if (IsEmpty()) 
            {
                Console.WriteLine("Buffer is enmpty");
                return default(T);
            }
                  
            return dynamicArray[index];
            
        }

        protected void Remove(int index) 
        {
            if (index >= counter)
            {
                Console.WriteLine("This index is empty");
                return;
            }
            counter--;
            if (counter * 4 < _capacity)
            {
                if (_capacity > minBufferSize)
                {
                    _capacity = _capacity / 2;
                    T[] tempArray = new T[_capacity];
                    for (int i = 0; i <= counter; i++)
                    {
                        tempArray[i] = dynamicArray[i];
                    }
                    dynamicArray = tempArray;

                }

            }
            for (int k = index; k < counter; k++)
            {
                dynamicArray[k] = dynamicArray[k + 1];
            }
        }

        public int Capacity 
        {
           get { return _capacity; }
        }
        public int Size 
        {
            get { return counter-1; }
        }


    }
}
