using System;
using System.Collections.Generic;

namespace TheStorefront.DATA.EF.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public string? SupplierCity { get; set; }
        public string? SupplierState { get; set; }
        public string? SupplierCountry { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
