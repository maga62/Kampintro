using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsintro
{
    class Mylist<T>


    {
        T[] items;
        //constructor
        public Mylist()
        {
            items = new T[0]; // items mevcut eleman demek 

        }
        public void Add(T item)
        {
            T[] tempArray = items; // geçici dizi bunu referansı tutmak için kullanıyoruz. önceki elemanların kaybolmaması için(stak ve heap yapası mantığı)
            items = new T[items.Length + 1]; // dizinin eleman sayısını 1 arttırıyor
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];// geçici olarak vermiş olduğum değerleri yeniden üzerine alıyor 


            }
            items[items.Length - 1] = item; // items son elemanı 
        }
    }
}
