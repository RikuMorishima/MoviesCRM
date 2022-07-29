using Antra.MoviesCRM.Infrastructure.Data;
using Antra.MoviesCRM.Core.Contracts.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        protected readonly MovieCrmDbContext db;
        public BaseRepositoryAsync(MovieCrmDbContext _context)
        {
            db = _context;
        }
        public async Task<int> DeleteAsync(int id)
        {
            var entity = await db.Set<T>().FindAsync(id);
            db.Set<T>().Remove(entity);
            return await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await db.Set<T>().ToListAsync();
        }

        public async virtual Task<T> GetByIdAsync(int id)
        {
            return await db.Set<T>().FindAsync(id);
        }

        public Task<int> InsertAsync(T entity)
        {
            db.Set<T>().AddAsync(entity);
            return db.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Modified;
            return await db.SaveChangesAsync();
        }
    }
}
