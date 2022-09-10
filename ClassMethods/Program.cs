using System;
using System.Collections.Generic;

namespace ClassMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            {
                product1.ProductName = "Elma";
                product1.UnitPrice = 15;
                product1.UnitInStock = 300;
            }

            Product product2 = new Product();
            {
                product2.ProductName = "Armut";
                product2.UnitPrice = 12;
                product2.UnitInStock = 200;
            }

            Product product3 = new Product() {ProductName = "Havyar", UnitPrice = 15, UnitInStock = 150 };

            ProductManager productManager = new ProductManager();
            {
                productManager.Add(product1);
                productManager.Add(product2);
                productManager.Add(product3);

                //for the blank
                Console.WriteLine();
                //for the blank

                productManager.Update(product1);
                productManager.Update(product2);
                productManager.Update(product3);
            }
        }
    }
}
