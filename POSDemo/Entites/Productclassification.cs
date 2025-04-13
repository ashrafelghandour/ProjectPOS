using System;
using System.Collections.Generic;

namespace POSDemo.Entites;

public partial class Productclassification
{
    public int Id { get; set; }

    public string Categoryname { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
