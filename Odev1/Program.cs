using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ternary operatörü - koşullu bir ifadeyi tek satırda yazmaya yarar.
            int sayi1 = 1, sayi2 = 3;
            var sonuc= sayi1 > sayi2 ? "doğru" : "yanlış";
            Console.WriteLine(sonuc);

            //switch - if elseye alternatif gibidir.
            int day = 2;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
            }

            //1den 5e kadar yazdırma

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("For bitti");
            int a = 1;
            while (a<=5)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.WriteLine("while bitti");
            int[] sayilar = new int[] { 1, 2, 3, 4, 5 };
            foreach (var b in sayilar)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("foreach bitti");
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Mouse";
            product1.Unit = 15;
            product1.UnitPrice = 150;
            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Keyboard";
            product2.Unit = 25;
            product2.UnitPrice = 250;
            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "RAM";
            product3.Unit = 35;
            product3.UnitPrice = 350;

            Product[] products = new Product[] {product1, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name+" | "+products[i].Unit + " | "+products[i].UnitPrice);
            }

            foreach (var p in products)
            {
                Console.WriteLine(p.Name+" | "+p.Unit+ " | " + p.UnitPrice);
            }

            int x= 0;
            while (x<products.Length)
            {
                Console.WriteLine(products[x].Name + " | " + products[x].Unit + " | " + products[x].UnitPrice);
                x++;
            }
        }

        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Unit { get; set; }
            public int UnitPrice { get; set; }

        }
    }
}
