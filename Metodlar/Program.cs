using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Id = 1;
            urun1.Name = "çilek";
            urun1.Price = 11;
            urun1.Aciklama = "natural çilek";

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.Name = "Karpuz";
            urun2.Price = 32;
            urun2.Aciklama = "diyarbakır karpuzu";

            Product urun3 = new Product();
            urun3.Name = "patlıcan";
            urun3.Price = 24;

            Product[] urunler = new Product[] { urun1, urun2 };
            foreach (var meyveler in urunler)
            {
                Console.WriteLine(meyveler.Id + " meyve adı = " + meyveler.Name + "  meyve fiyatı = " + meyveler.Price);
                Console.WriteLine("*********");
            }

            Product[] urunler2 = new Product[] { urun3 };
            foreach (var sebzeler in urunler2)
            {
                Console.WriteLine(sebzeler.Name + sebzeler.Price + "  ürün ıd olmadığı için 0 giriyor   " + sebzeler.Id);
            }

            Console.WriteLine("METODLAR !!!!!!!!!!!!!!!!!!");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Update(urun1);
            sepetManager.Update(urun2);
            sepetManager.Update(urun3);
            
        }
    }
}
