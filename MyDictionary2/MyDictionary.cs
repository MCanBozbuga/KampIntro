using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary2
{
    class MyDictionary<T, T2>
    {
        T[] _array;
        T2[] _array2;
        public MyDictionary()
        {
            _array =  new T[0];
            _array2 = new T2[0];
        }
        public void Add(T key , T2 value)
        {
            T[] tempkeyArray = _array;
            _array = new T[tempkeyArray.Length + 1];
            for (int i = 0; i < tempkeyArray.Length; i++)
            {
                _array[i] = tempkeyArray[i];
            }
            _array[_array.Length -1] = key;

            T2[] tempvalueArray = _array2;
            _array2 = new T2[tempvalueArray.Length + 1];
            for (int i = 0; i < tempvalueArray.Length; i++)
            {
                _array2[i] = tempvalueArray[i];
            }
            _array2[_array2.Length - 1] = value ;
        }
        public void Sonuc()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }
        public void Sonuc2()
        {
            for (int i = 0; i < _array2.Length; i++)
            {
                Console.WriteLine(_array2[i]);
            }
        }

    }
    


}
