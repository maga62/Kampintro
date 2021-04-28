using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product //özellikler class'ı
    {
        public int Id { get; set; }
        public int CategoriyId { get; set; }

        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        //urunun stok adedi
        public int UnitsInStock { get; set; }


    }
}
