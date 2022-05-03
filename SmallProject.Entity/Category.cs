using System;
using System.Collections.Generic;

#nullable disable

namespace SmallProject.Entity
{
    public partial class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        public Guid Uniqueld { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
