using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        { // kurs verileri yani kime ait kim bunu yazdı falan filan burada yazılmakta  ve her kurs için ayrı ayrı veri alınmakta 
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "java";
            kurs1.KursEgitmen = "Muhammed";
            kurs1.IzlenmeOranı = 8887;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c#";
            kurs2.KursEgitmen = "Fatih";
            kurs2.IzlenmeOranı = 8887;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.KursEgitmen = "kenan Komutan ";
            kurs3.IzlenmeOranı = 8887;


            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursEgitmen + " " + kurs1.IzlenmeOranı);
            //kurslari tutacak dizi oluşturduk
            Kurs[] Kursalar = new Kurs[]
            {
                kurs1,kurs2,kurs3

            };
            // kurslar dizisi uzerinde gezerek bir foreach
            foreach (Kurs kurs in Kursalar)
            {
                Console.WriteLine(kurs.KursEgitmen);
                Console.WriteLine(kurs.KursAdi+":"+kurs.KursEgitmen+":"+kurs.IzlenmeOranı);
                

            }
        }
    }
    
    class Kurs
    {// bu kalas biri veri yapısını düşün class yazdık ve bu klasdan bizim neler alacal isek onun veri hiyarerşisini oluşturdukk 
        // bu klass yukarıda bir veri yapısı olarak çağrılacak ve bu yapını içinde ne tanımlı ise dışarda bunu kullana bileceğiz 
        public string KursAdi { get; set; }
        public string KursEgitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
