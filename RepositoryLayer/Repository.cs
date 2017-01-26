using System;
using System.Linq;
using System.Collections.Generic;

namespace RepositoryLayer
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal Repository(System.Data.Entity.DbContext context)
        {
            Context = context;
        }

        internal protected System.Data.Entity.DbContext Context { get; }

        public TEntity Get(int id)
        {
            return this.Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return this.Context.Set<TEntity>().Where(predicate);
        }

        public void Add(TEntity entity)
        {
            this.Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            this.Context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            this.Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            this.Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
