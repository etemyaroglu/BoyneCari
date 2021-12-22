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
    public abstract class GenericRepository<T> : IRepository<T> where T : IEntity
    {
        protected readonly IMongoDataContext client;
        protected IMongoCollection<T> collection;

        protected GenericRepository(IMongoDataContext context)
        {
            client = context;
            collection = client.GetCollection<T>(typeof(T).Name);
        }
        public virtual T Get(string id)
        {
            return collection.Find<T>(x => x.Id == id).FirstOrDefault();
        }
        public virtual async Task<T> GetAsync(string id)
        {
            return await collection.Find<T>(x => x.Id == id).FirstOrDefaultAsync();
        }
        public virtual T Get(Expression<Func<T, bool>> predicate = null)
        {
            return collection.Find<T>(predicate).FirstOrDefault();
        }
        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await collection.Find<T>(predicate).FirstOrDefaultAsync();
        }

        public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            return predicate == null
                ? collection.AsQueryable()
                : collection.AsQueryable().Where(predicate);
        }
        public virtual IQueryable<T> GetQueryable()
        {
            return collection.AsQueryable();
        }
        public virtual IMongoCollection<T> GetCollection()
        {
            return collection;
        }
        public virtual T Insert(T model)
        {

            collection.InsertOne(model);
            return model;
        }
        public void Update(T model)
        {
            collection.FindOneAndReplace(x => x.Id == model.Id, model);
            
        }
        public virtual void Delete(string id)
        {
            collection.DeleteOne(x => x.Id == id);
        }

    }
}
