using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace TheStorefront.DATA.EF.Models
{
    #region Category
    public class CategoryMetadata
    {
        //since this a PK, we should never see it in a view, or have to enter a value when creating/editing.
        //For those reasons, we will not need to apply any metadata to a PK
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "* Category Name is required")]
        [StringLength(50)]
        [Display(Name = "Category")]
        public string CategoryName { get; set; } = null!;

        [StringLength(500)]
        [Display(Name = "Description")]
        public string? CategoryDescription { get; set; }
    }
    #endregion

    #region Product
    public class ProductMetadata
    {
        public int ProductId { get; set; }

        [StringLength(200)]
        [Display(Name = "Component")]
        [Required]
        public string ProductName { get; set; } = null!;


        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "Price")]
        [Range(0, (double)decimal.MaxValue)]
        [Required]
        public decimal ProductPrice { get; set; }

        
        [Display(Name = "RAM (IN GB)")]
        public int RAM { get; set; }

        [StringLength(50)]
        [Display(Name = "Socket Support")]
        public string SocketSupport { get; set; } = null!;

        [StringLength(4)]
        [Display(Name = "Release Year")]
        public string YearReleased { get; set; } = null!;

        [Required]
        [Range(0, short.MaxValue)]
        [Display(Name = "In Stock")]
        public short UnitsInStock { get; set; }
       
        //fk
        public int CategoryId { get; set; }
        //fk
        public int? SupplierId { get; set; }


        [StringLength(75)]
        [Display(Name = "Image")]
        public string? ProductImage { get; set; }
    }
    #endregion

    #region Supplier
    public class SupplierMetadata
    {
        public int SupplierId { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Supplier")]
        public string SupplierName { get; set; } = null!;

        
        [Required]
        [StringLength(100)]
        public string City { get; set; } = null!;

        [StringLength(2)]
        public string? State { get; set; }

        [Required]
        [StringLength(100)]
        public string? Country { get; set; }
    }
    #endregion

    #region UserDetail
    public class UserDetailMetadata
    {
        public string UserId { get; set; } = null!;

        [StringLength(50)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; } = null!;

        [StringLength(50)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; } = null!;
        [StringLength(150)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? City { get; set; }
        [StringLength(2)]
        public string? State { get; set; }
        [StringLength(5)]
        [DataType(DataType.PostalCode)]
        public string? Zip { get; set; }
        [StringLength(24)]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
    }
    #endregion
}
