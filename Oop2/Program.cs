using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            // gercek musteri giriişi
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.Musterino = "111111";
            musteri1.Adi = "ali";
            musteri1.Soyadi = "Ferman";
            musteri1.TcNo = "7679589";


            //Tuzel musteri girisi 
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.Musterino = "76786868";
            musteri2.SirketAdi = "kodluyoruz";
            musteri2.VergiNo = "544457a";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);












            //Gerçek Müşteriler - Tüzel Müşteriler bir birinin yerine kullanılamaz bunun gibi musteri1.SirketAdi = "?";
            //SOLID




        }
    }
}
