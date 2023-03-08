using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
        //kopyala yapıştır ampulden move type dersen yeni classa kopyalar ve oluşturur
    }
}
