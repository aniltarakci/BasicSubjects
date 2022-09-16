using ProjectDemo.DataAccess;
using ProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Business
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if(product.ProductName == "Laptop")
            {
                throw new DuplicateProductException("Laptop eklenemez.");
            }
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
