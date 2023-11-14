using System;
using System.Collections.Generic;

namespace ExpenseTracker.Models;

public partial class Note
{
    public int Id { get; set; }

    public int? Categoryid { get; set; }

    public string? Text { get; set; }

    public decimal? Ruprice { get; set; }

    public decimal? Usdprice { get; set; }

    public decimal? Brprice { get; set; }

    public DateTime Date { get; set; }

    public virtual Category? Category { get; set; }
}
