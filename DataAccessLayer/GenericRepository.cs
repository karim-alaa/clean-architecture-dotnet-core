using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using SharedConfig.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GenericRepository<TEntity> where TEntity : class, new()//: IGenericRepository<TEntity> 
    {
        protected readonly DBContext dbContext;
        protected readonly AppConfig _config;
        public GenericRepository(DBContext DbContext, AppConfig config)
        {
            dbContext = DbContext;
            _config = config;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            return (await dbContext.Set<TEntity>().AddAsync(entity)).Entity;
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbContext.Set<TEntity>().Where(predicate).CountAsync();
        }

        public async Task<int> CountAsync()
        {
            return await dbContext.Set<TEntity>().CountAsync();
        }

        public async Task<TEntity> FindAsync(params object[] predicate)
        {
            return await dbContext.Set<TEntity>().FindAsync(predicate);
        }

        public TEntity Update(TEntity entity)
        {
            return dbContext.Set<TEntity>().Update(entity).Entity;
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return dbContext.Set<TEntity>().Where(predicate);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await dbContext.Set<TEntity>().ToListAsync();
        }
    }
}
