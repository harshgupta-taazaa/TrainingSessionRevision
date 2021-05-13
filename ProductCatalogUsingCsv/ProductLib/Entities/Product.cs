using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLib.Entities
{
    class Product:Category
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        //public string ProductName { get; set; }

        //public int Price { get; set; }
        //public string Category { get; set; }

        //public string Manufacturer { get; set; }

        ////public string ProductShortCode { get; set; }

        //public override string ToString()
        //{
        //    return " Id : " + ProductId + " Product Name : " + ProductName + " Price : " + Price + " Catogery :"
        //        + CategoryName + " Manufacturer :" + Manufacturer + " Short Code : " + ShortCode + " Description : " + Description;

        //}
    }
}
