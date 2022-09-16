using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            {
                new Category { CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category { CategoryId = 2, CategoryName = "Telefon"},
            };

            List<Product> products = new List<Product>()
            {
                new Product{ ProductId = 1, CategoryId = 1, ProductName ="Hp Laptop", QuantityPerUnit = "32GB Ram", UnitPrice = 18000, UnitsInStock = 5},
                new Product{ ProductId = 2, CategoryId = 1, ProductName ="Asus Laptop", QuantityPerUnit = "16GB Ram", UnitPrice = 18000, UnitsInStock = 3},
                new Product{ ProductId = 3, CategoryId = 1, ProductName ="Acer Laptop", QuantityPerUnit = "8GB Ram", UnitPrice = 4900, UnitsInStock = 2},
                new Product{ ProductId = 4, CategoryId = 2, ProductName ="Xiaomi Telefon", QuantityPerUnit = "16GB Ram", UnitPrice = 5000, UnitsInStock = 15},
                new Product{ ProductId = 5, CategoryId = 2, ProductName ="Samsung Telefon", QuantityPerUnit = "8GB Ram", UnitPrice = 8000, UnitsInStock = 0}
            };

            //GetProducts(products);
            //Any(products);
            //Find(products);
            //FindAll(products);
            //Where(products);
            //OrderByAscending(products);
            //OrderByDescending(products);
            //ThenBy(products);
            //ThenByDescending(products);
            //GetAllWithFromIn(products);
            //WhereWithFromIn(products);
            //OrderByAscendingWithFromIn(products);
            //OrderByDescendingWithFromIn(products);
            //ClassicLinqWithFromIn(products);
            //JoinWithFromIn(categories, products);
        }

        static void JoinWithFromIn(List<Category> categories, List<Product> products)
        {
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result)
            {
                Console.WriteLine("{0} --- {1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        static void ClassicLinqWithFromIn(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice, };
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void OrderByDescendingWithFromIn(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.ProductName descending
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void OrderByAscendingWithFromIn(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.ProductName ascending
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void WhereWithFromIn(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000 && p.CategoryId == 2
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void GetAllWithFromIn(List<Product> products)
        {
            var result = from p in products
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void ThenByDescending(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void ThenBy(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void OrderByDescending(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void OrderByAscending(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void Where(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top"));
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void FindAll(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("Tel"));
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void Find(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        static void Any(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            return result;
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    class ProductDto //Product Data transformation object
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
