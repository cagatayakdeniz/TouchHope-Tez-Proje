using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TouchHope.DataAccess.Abstract;
using TouchHope.DataAccess.Concrete.Contexts;
using TouchHope.Entities.Abstract;

namespace TouchHope.DataAccess.Concrete.Repositories
{
    public class EfGenericDal<TEntity> : IGenericDal<TEntity> where TEntity : class, IEntity, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using (var context = new TouchHopeContext())
            {
                context.Entry(entity).State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (var context = new TouchHopeContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Set<TEntity>().FindAsync(id);
            }
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Set<TEntity>().ToListAsync();
            }
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Set<TEntity>().OrderByDescending(keySelector).ToListAsync();
            }
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Set<TEntity>().Where(filter).OrderByDescending(keySelector).ToListAsync();
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TouchHopeContext())
            {
                return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (var context = new TouchHopeContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }
    }
}
