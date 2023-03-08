using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Individual - gerçek müşteri
    class GercekMusteri:Musteri //müşterinin çocuğu demektir, müşteri ebeveyn
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
