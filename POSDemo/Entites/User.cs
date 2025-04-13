using System;
using System.Collections.Generic;

namespace POSDemo.Entites;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte[]? Image { get; set; }

    public virtual ICollection<SelesBill> SelesBills { get; set; } = new List<SelesBill>();
}
