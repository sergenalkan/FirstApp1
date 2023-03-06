using System;
using System.Collections.Generic;

namespace Gun4_Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir Dictionary örneği oluşturma.
            Dictionary<int, string> futbolcular = new Dictionary<int, string>();

            // Dictionary'ye eleman ekleme.

            futbolcular.Add(10, "Delgado");
            futbolcular.Add(13, "Bobo");
            futbolcular.Add(3, "Adriano");

            // Dictionary'deki tüm elemanların yazdırılması.
            foreach (KeyValuePair<int, string> kvp in futbolcular)
            {
                Console.WriteLine("Forma No = {0}, İsim = {1}", kvp.Key, kvp.Value);
            }

            // Dictionary'deki belirli bir elemanın değerini güncelleme.
            futbolcular[13] = "Atiba";
            foreach (KeyValuePair<int, string> kvp in futbolcular)
            {
                Console.WriteLine("Forma No = {0}, İsim = {1}", kvp.Key, kvp.Value);
            }
            // Dictionary'deki belirli bir elemanın değerini yazdırma.
            string value;
            if (futbolcular.TryGetValue(10, out value))
            {
                Console.WriteLine("Futbolcu Adı: {0}", value);
            }
            else
            {
                Console.WriteLine("10 Numara yok.");
            }
           
            Console.WriteLine("MyDictionary started");

            MyDictionary<int, string> futbolcular2 = new MyDictionary<int, string>();
            futbolcular2.Add(10, "Delgado");
            futbolcular2.Add(13, "Atiba");
            futbolcular2.Add(3, "Adriano");

            for (int i = 0; i < futbolcular2.Count; i++)
            {
                Console.WriteLine("Forma No: "+futbolcular2.KeyItems[i]+" | İsim: "+futbolcular2.ValueItems[i]);
            }
        }
    }
}
