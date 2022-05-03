using SmallProject.Entity;
using SmallProject.Repository.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject.DataAccessLayer.Abstract
{
    public interface IProductDal : IBaseRepository <Product>
    {
    }
}
