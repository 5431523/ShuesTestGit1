using System;
using System.Collections.Generic;

namespace ShoesTest1.Models;

public partial class Product
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdType { get; set; }

    public short IdCategory { get; set; }

    public int IdManufacturer { get; set; }

    public string Img { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Composition { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual Type Type { get; set; } = null!;

    public virtual ICollection<WarehouseProduct> WarehouseProducts { get; set; } = new List<WarehouseProduct>();
}
