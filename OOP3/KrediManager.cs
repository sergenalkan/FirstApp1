using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //bütün bilgiler değişik kredilerde, böyle durumda interface yapılır
    //Okunurluk artsın diye I harfiyle başlatırız
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
    //interfaceleri aynı olan, ama içerikleri farklı olan durumlarda kullanılır
}
