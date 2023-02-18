using System;

namespace Odev2ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Ediz";
            musteri.Soyad = "Alkan";
            musteri.TelNo = 10;
            Musteri musteri1 = new Musteri();
            musteri1.Id = 2;
            musteri1.Ad = "Sercan";
            musteri1.Soyad = "Alkan";
            musteri1.TelNo = 100;
            
            Musteri[] must = new Musteri[] { musteri, musteri1 };
            foreach (var ara in must)
            {
                Console.WriteLine(ara.Ad+"||"+ara.Soyad);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Listeler(1,"Sergen", "Alkan");
            musteriManager.Sil(musteri1);
            musteriManager.List(musteri1,musteri);
        }
    }
}
