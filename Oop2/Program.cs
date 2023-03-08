using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir nesnede bir yeri kullanmak zorunda değilsen kullanma
            //Matematiksel işlem yoksa metinsel yap, daha verimli olur | int-string
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "10987654321";
            //Gerçek Müşteri - Tüzel Müşteri
            //Birbirine benziyor diye birbirinin yerine kullanma
            //SOLID


            //new görürsen ref.no olduğunu anla 
            //Musteri sınıfı hem gerçek hem de tüzeli görebiliyor
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
