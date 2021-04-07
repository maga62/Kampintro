using System;


namespace Metodlar
{
    class Program
    {
        // aynı kodu tekrar tekrar yazmamak ortak metodları tekrar kullan aynı kodu tekrar tekrar yazma
        static void Main(string[] args)
        {
            // sepete ekleme butonu tekrar tekrar kullanılan bir buton bu biton için bir kez kod yazılır
            Urun urun1 = new Urun();//klasın örneği
            urun1.Adi = "Elma";
            urun1.Fiyat = 14;
            urun1.Aciklama = "Guba alması";

            Urun urun2 = new Urun();
            urun2.Adi = "çilek";
            urun2.Fiyat = 19.99;
            urun2.Aciklama = "Organik Çilek";

            Urun urun3 = new Urun();
            urun3.Adi = "karpuz";
            urun3.Fiyat = 5;
            urun3.Aciklama = "Adana karpuzu";

            Urun[] urunler = new Urun[] {
                urun1,urun2,urun3
            };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi+":"+urun.Aciklama+" ="+urun.Fiyat+"$");
                Console.WriteLine("----------------------------------------");

            }

            
            Console.WriteLine("---------------Metodlar--------------");
            //Instance = Örnek oluşturma
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);











            
        }
    }
}
