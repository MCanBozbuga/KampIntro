using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];   // Eleman sayısı 0
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Geçici Array. Böylece eleman sayısını arttırdığımızda new'lediğimizde eski değerler kaybolmaz.
            items = new T[items.Length+1];  // dizinin eleman sayısını verir. Eleman sayısını  1 arttırdık.
        }
    }
}
