using ProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.DataAccess
{
    public interface IAsyncEntityRepository<T> where T : class, IEntity, new()
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        public Task AddAsync(T entitiy);
        public Task UpdateAsync(T entitiy);
        public Task DeleteAsync(T entitiy);
    }
}
