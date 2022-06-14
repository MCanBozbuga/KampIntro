using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();           //Ekranda açılan kutu
            IKrediManager tasitKrediManager = new TasitKrediManager(); 
            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);          //Böylede yapılır. Aşağıda liste yöntemiyle de yapılır.
            
            

            Console.WriteLine("-----------LİSTE YÖNTEMİ---------------");
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
            List<ILoggerService> loggerServices2 = new List<ILoggerService>() {databaseLoggerService, fileLoggerService };

            basvuruManager.KrediOnBilgilendirilmesiYap(krediler);
            basvuruManager.KrediOnBilgilendirilmesiYap(loggerServices2);
        }
    }
}
