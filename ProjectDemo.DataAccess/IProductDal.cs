using ProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAll();
        public void Add(Product product);
    }
}
