using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);
        TEntity Update(TEntity entity);
        Task<TEntity> FindAsync(params object[] predicate);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAllAsync();
        Task<int> CountAsync();
    }
}
