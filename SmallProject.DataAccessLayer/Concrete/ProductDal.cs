using Microsoft.EntityFrameworkCore;
using SmallProject.DataAccessLayer.Abstract;
using SmallProject.Entity;
using SmallProject.Repository.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject.DataAccessLayer.Concrete
{
    public class ProductDal : BaseRepository<Product>, IProductDal
    {
        public ProductDal (DbContext dbContext)
            : base(dbContext)
            { 
        }
    }
}
