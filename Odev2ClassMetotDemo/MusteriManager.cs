using System;
using System.Collections.Generic;
using System.Text;

namespace Odev2ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" isimli musteri eklendi");
        }
        public void Listeler(int id, string ad, string soyad)
        {
            Console.WriteLine(ad+" isimli musteri listelendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" IDli musteri silindi");
        }

        public void List(params Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Ad Soyad:" + musteri.Ad + "" + musteri.Soyad + "\n" + "Id:" + musteri.Id + "\n" + "TC:" + musteri.TelNo);
            }
        }
    }
}
