using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager //Bütün kredilerde hesaplama olsun.(Kredi managerda hesapla yazdık.)
    {
        public void Hesapla()
        {
            Console.WriteLine(" ihtiyac kredisi hesaplandı");
        }

        public void Yap()
        {
            throw new NotImplementedException();
        }
    }
}
