using System;
using System.Collections.Generic;

namespace ShoesTest1.Models;

public partial class Category
{
    public string Category1 { get; set; } = null!;

    public short Id { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
