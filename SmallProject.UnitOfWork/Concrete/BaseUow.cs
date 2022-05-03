using Microsoft.EntityFrameworkCore;
using SmallProject.DataAccessLayer.Abstract;
using SmallProject.DataAccessLayer.Concrete;
using SmallProject.Entity;
using SmallProject.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject.UnitOfWork.Concrete
{ 
         public class BaseUow : IBaseUow
    {
        private static DbContext _dbContext;
        private static DbContext dbContext
        {
           
            get 
            {  if (_dbContext == null) _dbContext = new EcommerceContext();
            return _dbContext; }
        }

        public ICategoryDal CategoryDal => new CategoryDal(dbContext);

        public IProductDal Product =>  new  ProductDal(dbContext);

        public async Task<int> SaveChanges()
        {
          return
        }
    }
    
      }
    
