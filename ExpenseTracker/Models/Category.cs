using System;
using System.Collections.Generic;

namespace ExpenseTracker.Models;

public partial class Category
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual User? User { get; set; }
}
