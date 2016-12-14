using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    interface IMyQueue<T> 
    {
            void Enqueue(T ElementToEnqueue);
            T Dequeue();
        
    }
}
