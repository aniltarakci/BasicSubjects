using ProjectDemo.Business;
using ProjectDemo.DataAccess;
using ProjectDemo.Entities;
using System;

namespace ProjectDemo.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager(new ProductDal());

            //productManager.Add(new Product { ProductName = "Masa", CategoryId = 1, QuantityPerUnit = "altın kaplama masa", UnitPrice = 1000, UnitsInStock = 10 });
            //productManager.Update(new Product {ProductId = 78, ProductName = "Ipad", CategoryId = 2, QuantityPerUnit = "Süper Tablet", UnitPrice = 9000, UnitsInStock = 31 });
            //productManager.Delete(new Product { ProductId = 78 });
            //productManager.GetById(1);

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //Console.WriteLine(productManager.GetById(1).ProductName);

            //PersonelManager personelManager = new PersonelManager(new PersonelDal());

            //foreach (var personel in personelManager.GetAll())
            //{
            //    Console.WriteLine("{0} / {1} / {2}", personel.Id, personel.Ad, personel.SoyAd);
            //}

            //try
            //{
            //    productManager.Add(new Product { ProductId = 10, ProductName = "Laptop", QuantityPerUnit = "altın kaplama masa", UnitPrice = 1000, UnitsInStock = 10 });
            //}
            //catch (DuplicateProductException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //ProductManager productManager = new ProductManager(new ProductDal());

            //foreach (var product in productManager.GetAllAsync().Result)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
        }
    }
}
