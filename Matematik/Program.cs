using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem toplama = new DortIslem();
            toplama.Topla(6, 9);
            toplama.Topla(9, 6);

            Class1 cikar = new Class1();
            cikar.Cikar(6, 9);
            cikar.Cikar(10, 2);

        }
    }
}
