using System;

namespace Dongu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
            string k1 = "urun bir";
            string k2 = "urun iki";
            // array - dizi
            string[] kurslar = new string[] {
            "urun bir","urun iki","urun uc","urun 4 "};



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine( kurslar[i]);

            }
            // foreach stringlere uygulanır 
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
        }
    }
}
