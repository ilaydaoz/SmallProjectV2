using System;
using System.Collections.Generic;

#nullable disable

namespace SmallProject.Entity
{
    public partial class Product
    {
        public int Id { get; set; }
        public Guid UniqeuId { get; set; }
        public string ProductName { get; set; }
        public int NumberOfProducts { get; set; }
        public int Sales { get; set; }
        public int Buying { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
