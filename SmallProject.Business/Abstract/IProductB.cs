using SmallProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject.Business.Abstract
{
   public interface IProductB
    {
        List<ProductDto> GetAll();
        ProductDto GetByUniqueId(Guid uniqueId);
        void Add(ProductDto dto);
        void Edit(ProductDto dto);
        void Remove(ProductDto dto);
        Task<int> SaveChanges();
    }
}
