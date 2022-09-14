﻿using ProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.DataAccess
{
    public interface IEntitiyRepository<T>
    {
        List<T> GetAll();
        List<T> GetById(int id);
        public void Add(T entitiy);
        public void Update(T entitiy);
        public void Delete(T entitiy);
    }
}
