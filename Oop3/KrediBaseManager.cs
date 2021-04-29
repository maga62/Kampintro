using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    //interfaceleri bir birinin alternatifi olan ve kod içeriğinin farklıolduğudurumlarda kullanırız
    interface IKrediBaseManager //bu interface şablon rolunu oynar aynı zamnda referans tutuculuk yapar 
    {
        //loglama türleri --- > veritabanında tuta biliriz ,sms atabiliriz
        void Hesapla(); // metod ve birden fazla metod olabilir



    }
}
