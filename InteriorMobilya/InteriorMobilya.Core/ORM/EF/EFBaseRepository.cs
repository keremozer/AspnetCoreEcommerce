using InteriorMobilya.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace InteriorMobilya.Core.ORM.EF
{
    public class EFBaseRepository<TContext, TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addEntity = context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deleteEntity = context.Remove(entity);
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            var context = new TContext();
            return filter == null ?
               context.Set<TEntity>().FirstOrDefault() :
               context.Set<TEntity>().FirstOrDefault(filter);

        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            var context = new TContext();
            return filter == null ?
                 context.Set<TEntity>().AsQueryable() :
                 context.Set<TEntity>().Where(filter).AsQueryable();

        }

        public void Update(TEntity entity)
        {
            var context = new TContext();
            var updateEntity = context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}
