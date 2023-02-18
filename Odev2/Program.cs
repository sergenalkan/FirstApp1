using System;
using System.Linq;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 20;
            int sayı2 = 30;
            var s=Topla(ref sayi1, sayı2);
            Console.WriteLine(s);
            Console.WriteLine(Carp(2,4));
            Console.WriteLine(Carp(2,4,8));
            Console.WriteLine(Topla2(1, 2, 3, 4, 5));
        }

        static int Topla(ref int sayi1, int sayi2)
        {
            //ref kullanırsan değişkene değer atamalısın ama metoddaki parametreye değere grek yok
            //out ise değikene değere gerek yok ama metoddaki parametrede kesin olmalı
            //sayi1 = 25;
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        //methods overload-metoda aşırı yüklenme
        static int Carp(int a, int b) 
        {
            return a * b;
        }
        static int Carp(int a, int b, int c)
        {
            return a * b*c;
        }


        //params metodu
        static int Topla2(params int[] sayilar)
        {
            return sayilar.Sum();
        }
        static int Topla3(int x, params int[] sayilar)
        {
            return sayilar.Sum();
        }
    }
}
