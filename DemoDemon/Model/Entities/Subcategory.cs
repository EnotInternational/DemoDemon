namespace DemoDemon.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subcategory")]
    public partial class Subcategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subcategory()
        {
            Product = new HashSet<Product>();
        }

        public int SubcategoryID { get; set; }

        public int? CategoryID { get; set; }

        public string FullCategoryName { get => $"{Category.CategoryName} {CategoryName}"; }
        [Required]
        [StringLength(256)]
        public string CategoryName { get; set; }

        public virtual Category Category { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
