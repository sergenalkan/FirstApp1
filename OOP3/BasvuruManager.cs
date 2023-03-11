using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection: hangi yöntemi seçeceğini enjekte ediyoruz
        public void BasvuruYap(IKrediManager krediManager, List<IloggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendir
            //Bütün design patternler burda anlaşılır
            //
            //Bütün başvurular konut kredisine göre olur, hatalı olur
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }            
        }
        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
