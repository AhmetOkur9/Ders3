using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3
{
    class sepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi: " + urun.Name );
        }

        public void Ekle2(string urunadi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete eklendi : " + urunadi);
        }
    }
}
