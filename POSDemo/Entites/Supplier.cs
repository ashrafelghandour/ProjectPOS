using System;
using System.Collections.Generic;

namespace POSDemo.Entites;

public partial class Supplier
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Note { get; set; }

    public string? Phone { get; set; }

    public string? Company { get; set; }

    public string? Email { get; set; }

    public bool? IsActive { get; set; }

    public byte[]? Image { get; set; }
}
