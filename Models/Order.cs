using System;
using System.Collections.Generic;

namespace ShoesTest1.Models;

public partial class Order
{
    public long Id { get; set; }

    public DateOnly Date { get; set; }

    public long IdUser { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<OrderWarehouse> OrderWarehouses { get; set; } = new List<OrderWarehouse>();
}
