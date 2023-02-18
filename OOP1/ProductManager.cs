using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager//manager görürsen - ürünle ilgili operasyonlar olur demek
    {
        //encapsulation - kapsülleme - kümülatif: bütün özellikleri product classında tanımlama
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;//değer döndürür
        }

        public void Topla2(int sayi1, int sayi2)//voide emir verirsin gider yapar bırakır
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
