using System;
using System.Collections.Generic;

namespace POSDemo.Entites;

public partial class SelesBillDetill
{
    public int Id { get; set; }

    public int PruductId { get; set; }

    public int SelesBillId { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public int? Quntity { get; set; }

    public decimal? TotalPrice { get; set; }

    public virtual Product Pruduct { get; set; } = null!;

    public virtual SelesBill SelesBill { get; set; } = null!;
}
