
using BoyneCari.Models.Entities.Base;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BoyneCari.Data
{
    public interface IRepository<T> where T : IEntity
    {
        IMongoCollection<T> GetCollection();
        IQueryable<T> GetQueryable();
        T Get(string id);
        Task<T> GetAsync(string id);
        T Get(Expression<Func<T, bool>> predicate = null);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate = null);
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        T Insert(T model);
        void Update(T model);
        void Delete(string id);
    }
}
