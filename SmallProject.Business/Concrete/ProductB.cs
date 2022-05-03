using SmallProject.Business.Abstract;
using SmallProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject.Business.Concrete
{
    public class ProductB : IProductB
    {
        public void Add(ProductDto dto)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductDto dto)
        {
            throw new NotImplementedException();
        }

        public List<ProductDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductDto GetByUniqueId(Guid uniqueId)
        {
            throw new NotImplementedException();
        }

        public void Remove(ProductDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }

      
    }
}
