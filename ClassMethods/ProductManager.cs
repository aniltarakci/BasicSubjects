using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi : " + product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi : " + product.ProductName);
        }
    }
}
