using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Kocaeli");
            sehirler.Add("Kocaeli");
            sehirler.Add("Kocaeli");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add2("İzmit");
            sehirler2.Add2("İzmit");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _tempArray; // geçici array
        public MyList()
        {
            _array = new T[0];   // Mylist'i new lediğimde burası çalışır.
        }
        public void Add2(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        

        public int Count
        {
            get { return _array.Length; }
           
        }

    }
}
