using ProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Business
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        public void Add(Product product);
        public void Delete(Product product);
        public void Update(Product product);
    }
}
