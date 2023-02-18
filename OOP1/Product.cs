using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet - bir kare altında noktalar var demek. Örn: prop tab tab
    class Product//bu tip classlarda sadece özellikler olur
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName  { get; set; }
        public double UnitPrice { get; set; }//ürünün birim fiyatı
        public int UnitsInStock { get; set; }//ürünün stok adedi

        //CRUD-CreateReadUpdateDelete
    }
}
