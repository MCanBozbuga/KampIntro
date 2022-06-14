using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int cikar = sayi1 - sayi2;
            Console.WriteLine(cikar);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            int bol = sayi1 - sayi2;
            Console.WriteLine(bol);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int carp = sayi1 * sayi2;
            Console.WriteLine(carp);
        }
    }
}
