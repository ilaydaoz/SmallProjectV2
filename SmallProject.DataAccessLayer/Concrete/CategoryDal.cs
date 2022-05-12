using SmallProject.DataAccessLayer.Abstract;
using SmallProject.Entity;
using SmallProject.Repository.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SmallProject.DataAccessLayer.Concrete
{
  public class  CategoryDal : BaseRepository<Category>, ICategoryDal
    {
       public CategoryDal (DbContext dbContext)
            :base(dbContext)
        {
        }
    }
}
