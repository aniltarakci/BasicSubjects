using ProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.DataAccess
{
    public class EfProductDal : IProductDal
    {
        List<Product> _products;
        public EfProductDal()
        {
            _products = new List<Product>()
            {
                new Product{ProductId = 1, ProductName = "Acer ef Bilgisayar", QuantityPerUnit = "32GB Ram", UnitPrice = 10000, UnitsInStock = 2},
                new Product{ProductId = 2, ProductName = "Lenovo ef Bilgisayar", QuantityPerUnit = "16GB Ram", UnitPrice = 8000, UnitsInStock = 5},
                new Product{ProductId = 3, ProductName = "Samsung ef Bilgisayar", QuantityPerUnit = "4GB Ram", UnitPrice = 5000, UnitsInStock = 7},
                new Product{ProductId = 4, ProductName = "Hp ef Bilgisayar", QuantityPerUnit = "8GB Ram", UnitPrice = 7000, UnitsInStock = 9},
            };
        }
        public void Add(Product product)
        {
            Console.WriteLine("Entity Framework ile eklendi.");
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
