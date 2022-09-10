using System;
using System.Collections.Generic;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Id = 1, ProductName = "Kalem", UnitPrice = 13 }; //Set

            Console.WriteLine("Ürün ID: " + product1.Id + " | " + "Ürün Adı: " + product1.ProductName + " | " + "Birim Fiyatı: " + product1.UnitPrice + " | " + "KDV'li Birim Fiyatı: " + product1.UnitPriceKdv); //Get
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceKdv
        {
            get { return UnitPrice + UnitPrice * 18 / 100; }
            set { UnitPriceKdv = value; }
        }

    }
}
