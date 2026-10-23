using System;
using System.Collections.Generic;

namespace ShoesTest1.Models;

public partial class WarehouseProduct
{
    public long Id { get; set; }

    public long IdProduct { get; set; }

    public short IdSize { get; set; }

    public short Quantity { get; set; }

    public virtual Product IdProductNavigation { get; set; } = null!;

    public virtual Size IdSizeNavigation { get; set; } = null!;

    public virtual ICollection<OrderWarehouse> OrderWarehouses { get; set; } = new List<OrderWarehouse>();
}
