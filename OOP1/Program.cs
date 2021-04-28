using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //Product product1->stack   : new Product()->Heap

            product1.Id = 1;// işsaretlemiş olduğum her alanı normalde biz kullanıcılardan alırızz eğer bir  proje yapacak olursak

            product1.CategoriyId = 2;//
            product1.ProductName = "Masa";// bir projede bu şu şekilde olur tbxProductName.Text
            product1.UnitPrice = 5009;//
            product1.UnitsInStock = 11;//
            


            


            Product product2 = new Product { Id=2,CategoriyId=5,ProductName="KALEM",UnitPrice=17,UnitsInStock=3};

            //örnek oluşturma
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //int double,bool .... değer tip
            // diziler,class, abstract class interface.... referans tiplerdir 



        }
    }
}
