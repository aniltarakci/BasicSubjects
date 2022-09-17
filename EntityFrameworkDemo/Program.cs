using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetAll();
            //GetProductsByCategory(1);
        }

        static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            //var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);
            var result = from p in northwindContext.Products
                         where p.CategoryId == categoryId
                         select p;

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
