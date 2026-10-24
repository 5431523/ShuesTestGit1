using System;
using System.Collections.Generic;

namespace ShoesTest1.Models;

public partial class User
{
    public long Id { get; set; }

    public short IdRole { get; set; }

    public DateOnly DateOfRegistration { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public string Login { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
