using System;
using System.Collections.Generic;

namespace ShoesTest1.Models;

public partial class OrderWarehouse
{
    public long Id { get; set; }

    public long IdOrder { get; set; }

    public long IdWarehouseProducts { get; set; }

    public short Quantity { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual WarehouseProduct WarehouseProduct { get; set; } = null!;
}
