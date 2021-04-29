using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface -> IKrediBaseManager olarakda çağıra bilirdik yani interface onu iplamente eden classın referansını tuta bilir
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            // interface -> IKrediBaseManager olarakda çağıra bilirdik
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            // interface -> IKrediBaseManager olarakda çağıra bilirdik
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILogerServices databaseLoggerService = new DatabaseLoggerService();
            ILogerServices fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

            //basvuruManager.Basvuruyap(tasitKrediManager,databaseLoggerService);
            basvuruManager.Basvuruyap(new EsnafKrediManager(),
                new List<ILogerServices> { new DatabaseLoggerService(), new SmsLoggerService() });
            //basvuruManager.Basvuruyap(tasitKrediManager, fileLoggerService);


            //basvuruManager.Basvuruyap(ihtiyacKrediManager);
            //basvuruManager.Basvuruyap(konutKrediManager); ekrandan hangisi seçilirse ona göre hesaplama yapılır 

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() { ihtiyacKrediManager,tasitKrediManager
            };// bu listede hangi kredi seçilirse onu hesaplar sana geri dödürür

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
