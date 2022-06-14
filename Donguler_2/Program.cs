using System;

namespace Donguler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Kurslar = new string[] { "Kamp1", "Kamp2", "Kamp3", "Kamp1", "Kamp2", "Kamp3" };
            Console.WriteLine(Kurslar);

            for (int i = 0; i <Kurslar.Length; i++)
            {
                Console.WriteLine(Kurslar[i]);
            }
            Console.WriteLine("ara");
            foreach (var kurs in Kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("end");
        }
        
    }
 
}
