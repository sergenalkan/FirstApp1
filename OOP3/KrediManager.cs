using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //bütün bilgiler değişik kredilerde, böyle durumda interface yapılır
    //Okunurluk artsın diye I harfiyle başlatırız
    //Her metod bütün sınıflarda kullanılacaksa
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
    //alternatif sistemler için bir şablon ve referans tutucu
    
    //interfaceleri aynı olan, ama kod içerikleri farklı olan durumlarda kullanılır
}
