using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager //Bütün kredilerde hesaplama olsun.(Kredi managerda hesapla yazdık.)
    {
        public void Hesapla()
        {
            Console.WriteLine(" taşıt kredisi hesaplandı");
        }

        public void Yap()
        {
            throw new NotImplementedException();
        }
    }
}
