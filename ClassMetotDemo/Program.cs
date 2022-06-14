using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 1;
            musteri1.MusteriIsım = "Can";
            musteri1.MusteriSoyisim = "Bozbuğa";
            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = 2;
            musteri2.MusteriIsım = "Mustafa";

             
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle2(musteri1);
            musteriManager.Ekle2(musteri2);
            musteriManager.Cikar(musteri2);
            musteriManager.Guncelle(musteri1);
        }
    }
}
