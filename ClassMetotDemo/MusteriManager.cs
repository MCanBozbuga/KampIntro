using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle2(Musteri musteriler) 
        {
            Console.WriteLine("MÜŞTERİ EKLEME SİSTEMİ");
            Console.WriteLine("Musteri İsim Eklendi : " + musteriler.MusteriIsım);
            Console.WriteLine("Müşteri Soyisim Eklendi : " + musteriler.MusteriSoyisim);
            Console.WriteLine("Müşteri ID Eklendi : " + musteriler.MusteriID);
        }
        public void Cikar(Musteri musteriler) 
        {
            Console.WriteLine("***MÜŞTERİ ÇIKARDINIZ***");
            Console.WriteLine("Musteri İsim Çıkarıldı : " + musteriler.MusteriIsım);
            Console.WriteLine("Müşteri Soyisim Çıkarıldı : " + musteriler.MusteriSoyisim);
            Console.WriteLine("Müşteri ID Çıkarıldı : " + musteriler.MusteriID);
        }
        public void Guncelle(Musteri musteriler)  
        {
            Console.WriteLine("--------");
            Console.WriteLine("Musteri İsim Güncellendi : " + musteriler.MusteriIsım);
            Console.WriteLine("Müşteri Soyisim Güncellendi : " + musteriler.MusteriSoyisim);
            Console.WriteLine("Müşteri ID Güncellendi : " + musteriler.MusteriID);
            Console.WriteLine("--------");
        }
    }
}
