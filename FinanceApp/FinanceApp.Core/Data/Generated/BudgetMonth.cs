using System;
using System.Collections.Generic;

namespace FinanceApp.Core.Data.Generated;

public partial class BudgetMonth
{
    public int ID { get; set; }

    public int Year { get; set; }

    public byte Month { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<BudgetAllocation> BudgetAllocation { get; set; } = new List<BudgetAllocation>();

    public virtual ICollection<BudgetMove> BudgetMove { get; set; } = new List<BudgetMove>();
}
