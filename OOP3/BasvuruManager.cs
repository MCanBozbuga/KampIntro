using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            loggerService.Log();
            
        }
        public void KrediOnBilgilendirilmesiYap(List<IKrediManager> krediler)

        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();                //Listedeki her kredninin hesaplamasını yap.
            }
            
        }
        public void KrediOnBilgilendirilmesiYap(List<ILoggerService> loggerServices)
        {
            foreach (var item in loggerServices)
            {
                item.Log();
            }
        }

    }
}
