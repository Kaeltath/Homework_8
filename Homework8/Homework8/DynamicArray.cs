using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class DynamicArray<T> : Buffer<T>
    {
        private int minBufferSize = 5;

       public void Add(T element) 
        {
            counter++;
            if (IsFull()) 
            {
                Expand();              
            }

            dynamicArray[counter-1] = element;            
        }

       public void Insert(T element, int index)
       {
           counter++;
           if (IsFull())
           {
               Expand();
           }
           dynamicArray[index] = element;  
       }

        public T Get(int index) 
        {
            if (IsEmpty()) 
            {
                Console.WriteLine("Buffer is enmpty");
                return default(T);
            }
                  
            return dynamicArray[index];
            
        }

        public void Remove(int index) 
        {
            if (index >= counter)
            {
                Console.WriteLine("This index is empty");
                return;
            }
            counter--;
            if (counter * 4 < _capacity)
            {
                Shrink();
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

        private void Expand()
        {
        _capacity = _capacity * 2;
                
                    T[] tempArray = new T[_capacity];
                    for (int i = 0; i < dynamicArray.Length; i++)
                    {
                        tempArray[i] = dynamicArray[i];
                    }
                    dynamicArray = tempArray;
                    
        }

        private void Shrink ()
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

    }
}
