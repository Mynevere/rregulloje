using Microsoft.EntityFrameworkCore;
using Rregulloje.Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Infrastructure.Data.Repositories
{
    public class BaseRepository
    {
        private readonly ApplicationDbContext _context; 

        public BaseRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public virtual async Task<T> InsertAsync<T>(T entity) where T : class
        {
            await _context.Set<T>().AddAsync(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<T> UpdateAsync<T>(T t, object key) where T : class
        {
            if (t == null)
                return null;
            T exist = await _context.Set<T>().FindAsync(key);
            if (exist != null)
            {
                _context.Entry(exist).CurrentValues.SetValues(t);
                await _context.SaveChangesAsync();
            }
            return exist;
        }

        public virtual async Task<int> DeleteAsync<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> CountAsync<T>() where T : class
        {
            return await _context.Set<T>().CountAsync();
        }

        public async Task<ICollection<T>> FindAllAsync<T>(Expression<Func<T, bool>> match) where T : class
        {
            return await _context.Set<T>().Where(match).ToListAsync();
        }

        public virtual async Task<T> FindAsync<T>(Expression<Func<T, bool>> match) where T : class
        {
            return await _context.Set<T>().SingleOrDefaultAsync(match);
        }

        public virtual async Task<ICollection<T>> GetAllAsync<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetAsync<T>(int id) where T : class
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual async Task<ICollection<T>> FindByAsync<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public IQueryable<T> GetAllIncluding<T>(params Expression<Func<T, object>>[] includeProperties) where T : class
        {

            IQueryable<T> queryable = GetAll<T>();
            foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            {
                queryable = queryable.Include<T, object>(includeProperty);
            }

            return queryable;
        }

        private IQueryable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>();
        }
    }

}
