using System;
using System.Collections.Generic;

namespace MyDictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> SehirPlaka = new MyDictionary<string,int>();
            SehirPlaka.Add("İzmit",41);
            SehirPlaka.Add("Sakarya",54);
            SehirPlaka.Add("İstanbul",34);
            SehirPlaka.Add("Kırıkkale",71);
            SehirPlaka.Sonuc();
            SehirPlaka.Sonuc2();

        
            Console.WriteLine();
        }
    }
}
