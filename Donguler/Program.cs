using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "birinci kurs";
            string kurs2 = "ikinci kurs";
            string kurs3 = "üçüncü kurs";

            //array - dizi

            string[] kurslar = new string[] { "birinci kurs", 
                "ikinci kurs", "üçüncü kurs", "python" };

            for (int i = 1; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
