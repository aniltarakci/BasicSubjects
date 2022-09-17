using ProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.DataAccess
{
    public class ProductDal : IProductDal
    {
        public ProductDal()
        {

        }
        public void Add(Product product)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                northwindContext.Products.Add(product);
                northwindContext.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                northwindContext.Products.Remove(northwindContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                northwindContext.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Products.ToList();
            }
        }

        public Product GetById(int id)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                var productToUpdate = northwindContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;
                northwindContext.SaveChanges();
            }
        }
    }
}
