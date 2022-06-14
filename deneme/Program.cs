using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> kisiler = new MyDictionary<int, string>();
            kisiler.Add(1, "mustafa");
            kisiler.Add(2, "can");
            kisiler.Add(3, "bozbuğa");

            foreach (var kisi in kisiler.Valuee)
            {
                Console.WriteLine(kisi);
            }
            foreach (var kisi in kisiler.Keyy)
            {
                Console.WriteLine(kisi);
            }

        }
    }
}