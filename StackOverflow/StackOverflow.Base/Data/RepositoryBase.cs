using StackOverflow.Base.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Base.Data
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public RepositoryBase(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task InsertAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression = null)
        {
            return  expression != null ? await _context.Set<T>().AsQueryable().Where(expression).AsNoTracking().ToListAsync() :
               await _context.Set<T>().AsQueryable().AsNoTracking().ToListAsync();
        }

        public void DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<T> GetQuestionByIdAsync(Expression<Func<T, bool>> exception)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(exception);
        }

        public async Task<bool> SaveCompletedAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

      
    }
}
