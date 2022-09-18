using ProjectDemo.DataAccess;
using ProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Business
{
    public class PersonelManager : IPersonelService
    {
        IPersonel _personelDal;
        public PersonelManager(IPersonel personel)
        {
            this._personelDal = personel;
        }
        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }
    }
}
