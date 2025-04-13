using System;
using System.Collections.Generic;

namespace POSDemo.Entites;

public partial class SelesBill
{
    public int BillId { get; set; }

    public DateOnly Date { get; set; }

    public string? Notes { get; set; }

    public int CustomerId { get; set; }

    public decimal TotalPrice { get; set; }

    public decimal? Discount { get; set; }

    public decimal TotalAfterDiscount { get; set; }

    public int UserId { get; set; }

    public virtual Custmer Customer { get; set; } = null!;

    public virtual ICollection<SelesBillDetill> SelesBillDetills { get; set; } = new List<SelesBillDetill>();

    public virtual User User { get; set; } = null!;
}
