namespace DemoDemon.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockItem")]
    public partial class StockItem
    {
        public int StockItemID { get; set; }

        public int? ProductID { get; set; }

        public int? SizeID { get; set; }

        public int QuantityAvailable { get; set; }

        public virtual Product Product { get; set; }

        public virtual Size Size { get; set; }
    }
}
