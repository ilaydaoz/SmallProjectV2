using SmallProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject.Business.Abstract
{
  public interface ICategoryB
    {
        List<CategoryDto> GetAll();
        CategoryDto GetByUniqueId(Guid uniqueId);
        void Add(CategoryDto dto);
        void Edit(CategoryDto dto);
        void Remove(CategoryDto dto);
        Task<int> SaveChanges();
    }
}
