using ProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.DataAccess
{
    public class PersonelDal : IPersonel
    {
        public void Add(Personel entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Personel entitiy)
        {
            throw new NotImplementedException();
        }

        public List<Personel> GetAll()
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Personeller.ToList();
            }
        }

        public Personel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Personel entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
