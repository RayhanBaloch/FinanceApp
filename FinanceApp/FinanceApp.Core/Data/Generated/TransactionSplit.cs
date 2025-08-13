using System;
using System.Collections.Generic;

namespace FinanceApp.Core.Data.Generated;

public partial class TransactionSplit
{
    public int ID { get; set; }

    public int TransactionId { get; set; }

    public int? CategoryId { get; set; }

    public decimal Amount { get; set; }

    public string? Memo { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Transaction Transaction { get; set; } = null!;
}
