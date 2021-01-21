using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] items;
        // constructor
        public MyDictionary()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] TempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < TempArray.Length; i++)
            {
                items[i] = TempArray[i];
            }

            items[items.Length - 1] = item;

        }

        public int Length
        {
            get { return items.Length; }
        }
    }
}
