using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager //Bütün kredilerde hesaplama olsun.(Kredi managerda hesapla yazdık.)
    {
        public void Hesapla()
        {
            Console.WriteLine(" konut kredisi hesaplandı");
        }

        public void Yap()
        {
            throw new NotImplementedException();
        }
    }
}
