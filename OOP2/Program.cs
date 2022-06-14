using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "can";
            musteri1.Soyadi = "bozbuga";
            musteri1.Id = 1;
            musteri1.TcNo = "12345678";
            musteri1.MusteriNo = 225;

            Console.WriteLine("--------------------------");

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.SirketAdi = "tara";
            musteri2.Id = 2;
            musteri2.MusteriNo = 555;
            musteri2.VergiNo = 123;

            Console.WriteLine("--------------------------");

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

        }
    }
}
