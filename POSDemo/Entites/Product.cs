using System;
using System.Collections.Generic;

namespace POSDemo.Entites;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Code { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public string Note { get; set; } = null!;

    public byte[]? Image { get; set; }

    public int ClassesProduct { get; set; }

    public virtual Productclassification ClassesProductNavigation { get; set; } = null!;

    public virtual ICollection<SelesBillDetill> SelesBillDetills { get; set; } = new List<SelesBillDetill>();
}
