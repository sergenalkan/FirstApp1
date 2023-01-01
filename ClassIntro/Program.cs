﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.İzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Kerem Demiroğ";
            kurs2.İzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Eğitmen = "Berkay Demiroğ";
            kurs3.İzlenmeOranı = 60;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Eğitmen);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int İzlenmeOranı { get; set; }
    }
}
