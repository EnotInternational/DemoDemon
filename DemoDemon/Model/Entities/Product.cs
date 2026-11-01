namespace DemoDemon.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderItem = new HashSet<OrderItem>();
            StockItem = new HashSet<StockItem>();
        }

        public int ProductID { get; set; }

        [Required]
        [StringLength(256)]
        public string ProductName { get; set; }

        public int? SubcategoryID { get; set; }

        public int? ManufacturerID { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(2000)]
        public string Desctiption { get; set; }

        [StringLength(2000)]
        public string Compound { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }

        public virtual Subcategory Subcategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItem> StockItem { get; set; }
    }
}
