using System;
using System.Collections.Generic;

namespace FinanceApp.Core.Data.Generated;

public partial class BudgetAllocation
{
    public int ID { get; set; }

    public int BudgetMonthId { get; set; }

    public int CategoryId { get; set; }

    public decimal Amount { get; set; }

    public virtual BudgetMonth BudgetMonth { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;
}
