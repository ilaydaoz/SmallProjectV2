using System;
using System.Collections.Generic;

#nullable disable

namespace SmallProject.DataAccess
{
    public  class CategoryDto
    {
        public CategoryDto()
        {
            Products = new List<ProductDto>();
        }

        public int Id { get; set; }
        public Guid Uniqueld { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductDto> Products { get; set; }
    }
}
