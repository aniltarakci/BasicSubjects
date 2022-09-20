using Microsoft.EntityFrameworkCore;
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

        public async Task AddAsync(Product entitiy)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            await northwindContext.Products.AddAsync(entitiy);
            await northwindContext.SaveChangesAsync();
        }

        public void Delete(Product product)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                northwindContext.Products.Remove(northwindContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                northwindContext.SaveChanges();
            }
        }

        public Task DeleteAsync(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Products.ToList();
            }
        }

        public Task<List<Product>> GetAllAsync()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            return northwindContext.Products.ToListAsync();
        }

        public Product GetById(int id)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }

        public Task<Product> GetByIdAsync(int id)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            return northwindContext.Products.SingleOrDefaultAsync(p => p.ProductId == id);
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

        public Task UpdateAsync(Product entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
