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
            ProductManager productManager = new ProductManager(new ProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            try
            {
                productManager.Add(new Product { ProductId = 10, ProductName = "Laptop", QuantityPerUnit = "altın kaplama masa", UnitPrice = 1000, UnitsInStock = 10 });
            }
            catch (DuplicateProductException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
