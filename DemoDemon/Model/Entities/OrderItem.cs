namespace DemoDemon.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderItem")]
    public partial class OrderItem
    {
        public int OrderItemID { get; set; }

        public int? OrderID { get; set; }

        public int? ProductID { get; set; }

        public int? SizeID { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal UniyPrice { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
        public virtual Size Size { get; set; }
        public virtual decimal SizeValue { get => Size.SizeValue; }
        public virtual string ProductName { get => Product.ProductName; }
        public virtual string ManufacturerName { get => Product.Manufacturer.ManufacturerName; }
    }
}
