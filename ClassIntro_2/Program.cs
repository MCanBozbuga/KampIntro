using System;

namespace ClassIntro_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region // DERS 2 
            //Kurs kurs1 = new Kurs();  //Kurs1 ' i n var . Tipi Kurs.
            //kurs1.KursAdi = "C#";
            //kurs1.KursunEgitmeni = "ED";
            //kurs1.KursunIzlenmeOrani = 50;

            //Kurs kurs2 = new Kurs();  //Kurs1 ' i n var . Tipi Kurs.
            //kurs2.KursAdi = "java";
            //kurs2.KursunEgitmeni = "ED";
            //kurs2.KursunIzlenmeOrani = 54;

            //Kurs kurs3 = new Kurs();  //Kurs1 ' i n var . Tipi Kurs.
            //kurs3.KursAdi = "pyhton";
            //kurs3.KursunEgitmeni = "ED";
            //kurs3.KursunIzlenmeOrani = 55;

            //Kurs kurs4 = new Kurs();  //Kurs1 ' i n var . Tipi Kurs.
            //kurs4.KursAdi = "deneme";
            //kurs4.KursunEgitmeni = "ED";
            //kurs4.KursunIzlenmeOrani = 45;
            //// Console.WriteLine(kurs1.KursunIzlenmeOrani);   Uzun  yoldan yazdırma yöntemi.

            ////Array kullanarak kısa yöntemde hepsini yazdırdık.
            //Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };
            //foreach (var takmaisim in kurslar)
            //{
            //    Console.WriteLine("Kurs Adı = " + takmaisim.KursAdi + "  Kursun Eğitmeni = " + takmaisim.KursunEgitmeni + "  İzlenme Oranı =  " + takmaisim.KursunIzlenmeOrani);
            //}
            #endregion // 
            Product pantalon = new Product();
            pantalon.UrunAdi = "mavi";
            pantalon.UrunBedeni = "M";
            pantalon.UrunFiyati = 300;

            Product thsirt = new Product();
            thsirt.UrunAdi = "HM";
            thsirt.UrunBedeni = "L";
            thsirt.UrunFiyati = 100;

            Product[] urunler = new Product[]
            {
                pantalon,thsirt
            };
            foreach (var giyisi in urunler)
            {
                Console.WriteLine(giyisi.UrunAdi + giyisi.UrunBedeni + giyisi.UrunFiyati);
            }

        }
        #region DERS 2 CLASS
        //class Kurs
        //{
        //    public string KursAdi { get; set; }
        //    public string KursunEgitmeni { get; set; }
        //    public int KursunIzlenmeOrani { get; set; }

        //}
        #endregion
        class Product
        {
            public string UrunAdi { get; set; }
            public string UrunBedeni { get; set; }
            public int UrunFiyati { get; set; }
        }

    }


}
