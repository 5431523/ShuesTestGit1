using System;
using System.Collections.Generic;

namespace ShoesTest1.Models;

public partial class Size
{
    public short Id { get; set; }

    public decimal Size1 { get; set; }

    public virtual ICollection<WarehouseProduct> WarehouseProducts { get; set; } = new List<WarehouseProduct>();
}
