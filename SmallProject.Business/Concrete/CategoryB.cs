using SmallProject.Business.Abstract;
using SmallProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject.Business.Concrete
{
    public class CategoryB : ICategoryB
    {
        public void Add(CategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public void Edit(CategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public List<CategoryDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryDto GetByUniqueId(Guid uniqueId)
        {
            throw new NotImplementedException();
        }

        public void Remove(CategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }

       
    }
}
