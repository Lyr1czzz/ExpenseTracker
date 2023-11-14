using System;
using System.Collections.Generic;

namespace ExpenseTracker.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public decimal? Rubalance { get; set; }

    public decimal? Brbalance { get; set; }

    public decimal? Usdbalance { get; set; }

    public int Pincode { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
