using DAL.Abstarct_Repositories;
using DAL.DATA;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concerete_Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseClass
    {
        private readonly AppDbContext _context;
        private DbSet<T> _entities;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();

        }

        public async Task AddAsync(T t)
        {
            await _entities.AddAsync(t);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(int id)
        {
            var entity =await GetByIdAsync(id);
            _entities.Remove(entity);
            await _context.SaveChangesAsync();


        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task UpdateAsync(int id, T t)
        {
            var entityToUpdate = await GetByIdAsync(id);
            t.CreatedDate = DateTime.Now;
            _entities.Update(entityToUpdate);
            await _context.SaveChangesAsync();
        }
    }
}
