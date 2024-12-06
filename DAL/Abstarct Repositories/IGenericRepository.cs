using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstarct_Repositories
{
    public interface IGenericRepository<T> where T : BaseClass
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T t);
        Task UpdateAsync(int id, T t);
        Task DeleteAsync(int id);
    }
}
