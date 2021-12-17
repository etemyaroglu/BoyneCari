
using BoyneCari.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BoyneCari.Data
{
    public interface IRepository<T> where T : IEntity
    {
        IQueryable<T> GetQueryable();
        T Get(Guid id);
        Task<T> GetAsync(Guid id);
        T Get(Expression<Func<T, bool>> predicate = null);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate = null);
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        T Insert(T model);
        void Update(T model);
        void Delete(Guid id);
    }
}
