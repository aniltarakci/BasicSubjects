using ProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.DataAccess
{
    //ProductDal =Product Data Access Layer
    public class AdoProductDal : IProductDal
    {
        List<Product> _products;

        public AdoProductDal()
        {
            _products = new List<Product>()
            {
                new Product{ProductId = 1, ProductName = "Acer Bilgisayar", QuantityPerUnit = "32GB Ram", UnitPrice = 10000, UnitsInStock = 2},
                new Product{ProductId = 2, ProductName = "Lenovo Bilgisayar", QuantityPerUnit = "16GB Ram", UnitPrice = 8000, UnitsInStock = 5},
                new Product{ProductId = 3, ProductName = "Samsung Bilgisayar", QuantityPerUnit = "4GB Ram", UnitPrice = 5000, UnitsInStock = 7},
                new Product{ProductId = 4, ProductName = "Hp Bilgisayar", QuantityPerUnit = "8GB Ram", UnitPrice = 7000, UnitsInStock = 9},
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado.NET ile eklendi.");
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
