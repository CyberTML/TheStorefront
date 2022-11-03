using System;
using System.Collections.Generic;

namespace TheStorefront.DATA.EF.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal? ProductPrice { get; set; }
        public int? Ram { get; set; }
        public string? SocketSupport { get; set; }
        public string? YearReleased { get; set; }
        public short InStock { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public string? ProductImage { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}
