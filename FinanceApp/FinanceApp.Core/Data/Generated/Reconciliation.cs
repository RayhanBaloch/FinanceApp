using System;
using System.Collections.Generic;

namespace FinanceApp.Core.Data.Generated;

public partial class Reconciliation
{
    public int ID { get; set; }

    public int AccountId { get; set; }

    public DateOnly AsOf { get; set; }

    public decimal StatementBalance { get; set; }

    public decimal BalanceDifference { get; set; }

    public virtual Account Account { get; set; } = null!;
}
