using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        // METOD NASIL YAZILIR,
        public void Ekle(Product product)
        {
            Console.WriteLine("sepete eklendi     " + product.Name + product.Price + product.Aciklama);
        }
        public void Update(Product product)
        {
            Console.WriteLine("Güncellendiii   " + product.Name);
        }
    }
}
