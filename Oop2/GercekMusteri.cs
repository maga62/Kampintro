using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    //Individual
    // inherıtıns= Musteri classın içinde olan tüm özelliker buraya miras olarak aktar 
    class GercekMusteri: Musteri//:Musteri yazmak miras=inheritins olur. gercek musteri bir müsteridir demek 
    {
        
        public string TcNo { get; set; }

        
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
