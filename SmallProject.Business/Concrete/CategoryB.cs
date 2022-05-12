using SmallProject.Business.Abstract;
using SmallProject.DataAccess;
using SmallProject.UnitOfWork.Abstract;
using SmallProject.UnitOfWork.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject.Business.Concrete
{
    public class CategoryB : ICategoryB
    {
        private IBaseUow Uow;
        private IBaseUow uow
        {  
            get {
                if (Uow == null) Uow = new BaseUow();
                 return Uow; }
        }
        public void Add(CategoryDto dto)
        {
          
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
