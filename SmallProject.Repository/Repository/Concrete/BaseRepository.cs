using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SmallProject.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject.Repository.Repository.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T>
         where T : class, new()
    {
        protected readonly DbContext dbContext;

        public BaseRepository(DbContext dbContext)
        {

            this.dbContext = dbContext;
        }
        public void Add(T entity)
        {
            EntityEntry entityEntry = dbContext.Add(entity);
            entityEntry.State = EntityState.Added;
        }

        public void Delete(T entity)
        {
            EntityEntry entityEntry = dbContext.Remove(entity);
            entityEntry.State = EntityState.Deleted;
        }

        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Select(Expression<Func<T, bool>> predicate = null)
        {
          IQueryable<T> queryable = dbContext.Set<T>().AsQueryable();
            if (predicate != null) queryable = queryable.Where(predicate);
            return queryable;
        }

        public void Update(T entity)
        {
            EntityEntry entityEntry = dbContext.Update(entity);
            entityEntry.State = EntityState.Modified;
        }
      
    }
}
