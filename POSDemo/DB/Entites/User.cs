using System;
using System.Collections.Generic;

namespace POSDemo.DB.Entites;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte[]? Image { get; set; }
}
