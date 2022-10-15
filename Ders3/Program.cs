using System;

namespace Ders3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.ID = "1";
            urun1.Name = "elma";
            urun1.fiyat = 15;
            urun1.aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.ID = "2";
            urun2.Name = "Karpuz";
            urun2.fiyat = 80;
            urun2.aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product product in urunler)
            {
                Console.WriteLine(product.ID);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.fiyat);
                Console.WriteLine(product.aciklama);
                Console.WriteLine("--------------------");

 
            }
            Console.WriteLine("--------Metotlar--------");
            //instance - örnek
            sepetManager sepetYönet = new sepetManager();
            sepetYönet.Ekle(urun1);
            sepetYönet.Ekle(urun2);

            //Ekle2 nin farklı bir kullanımı
            sepetYönet.Ekle2("Armut", "Yeşil", 15);


        }
    }
}
