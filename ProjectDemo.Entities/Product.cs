using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Entities
{
    public class Product
    {
        public int ProductId { get; set; } // Ürün Id
        public string ProductName { get; set; } //Ürün Adı
        public string QuantityPerUnit { get; set; } //Ürün Açıklaması
        public decimal UnitPrice { get; set; } //Ürün Fiyatı
        public int UnitsInStock { get; set; } //Ürün Stok Adedi
    }
}
