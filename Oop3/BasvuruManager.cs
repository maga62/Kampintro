using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class BasvuruManager
    {
        // Method enjection yapıyoruz burada
        public void Basvuruyap(IKrediBaseManager krediBaseManager,List<ILogerServices>  logerServices) //hangi kredi istiyorsun? IKrediBaseManager tüm bilgileri tuttuğu için bunu kullanırız
        {
            //basvuru bilgilerini degerlendirme

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); //bu sekilde desem tum kredibaşvurularını konutkredi üzerinden hessaplamış olurum
            krediBaseManager.Hesapla();
            //logerServices.Log(); // tek log çağırdığımızda 
            // birden fazla log hem veritabanına loglama hemde sms gönderme 
            foreach (var loger in logerServices)

            {
                loger.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler)// hagi krediler bana uygun ! hepsini aynı anda hesaplamak
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
