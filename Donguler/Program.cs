using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazlım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangınç içi Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            
            
              //array - dizi

            string[] kurslar = new string[] { "Yazlım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangınç içi Temel Kurs", 
                "Java",
                "Python"};


            for (int i = 0; i<kurslar.Length; i++)
            {
                 Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
