using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    // sepet kodu ürün ekleme 
    class SepetManager
    {        /// <summary>
    /// 
    /// </summary>
    /// <param name="urun"></param>
        public void Ekle(Urun urun) // Urun urun parametreleri ' dir
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }
    }
}
