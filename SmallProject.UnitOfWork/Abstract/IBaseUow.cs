using SmallProject.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmallProject.UnitOfWork.Abstract
{
public interface IBaseUow 
    {
        ICategoryDal CategoryDal { get; }
        IProductDal Product { get; }
        Task<int> SaveChanges();
    }
}
