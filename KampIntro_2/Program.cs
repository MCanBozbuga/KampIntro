using System;

namespace KampIntro_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 1000;
            double oran = 1.50;
            bool girisYapildiMi = false;
            double dolarDun = 21;
            double dolarBugun = 21;

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış");
            }
            else
            {
                Console.WriteLine("sabit");
            }
            if (girisYapildiMi==true)
            {
                Console.WriteLine("yapildi");
            }
            else
            {
                Console.WriteLine("yapilmadi");
            }
             
            Console.WriteLine("Hello World!");
        }
    }
}
