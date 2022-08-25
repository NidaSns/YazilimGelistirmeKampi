using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    // herhangi bir veri tipi gelir string ,int veya herhangi bir tür listenin içine yazılabilir
    class MyList<T>
    {
        T[] items;

        // constructor ctor tab tab
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item) 
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

    }
}
