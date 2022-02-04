using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güveliği
            
            
            
            string KategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistememGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }            




            if (sistememGirisYapmismi == true)
            {
                Console.WriteLine("kullancı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(KategoriEtiketi);
            Console.WriteLine(KategoriEtiketi);

            Console.WriteLine(KategoriEtiketi);

            Console.WriteLine(KategoriEtiketi);

            Console.WriteLine(KategoriEtiketi);
        }
    }
}
