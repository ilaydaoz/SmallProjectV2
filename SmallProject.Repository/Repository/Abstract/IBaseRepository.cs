using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject.Repository.Repository.Abstract
{
    
        public interface IBaseRepository<T>
            where T : class, new()
        {
        IQueryable<T> Select(Expression<Func<T, bool>> predicate= null);
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
            Task<T> GetById(T entity);
            Task<List<T>> GetAll();
        }
 }   
