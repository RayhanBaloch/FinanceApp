using System;
using System.Collections.Generic;

namespace FinanceApp.Core.Data.Generated;

public partial class Category
{
    public int ID { get; set; }

    public int GroupId { get; set; }

    public string CategoryName { get; set; } = null!;

    public bool IsHidden { get; set; }

    public int SortOrder { get; set; }

    public virtual ICollection<BudgetAllocation> BudgetAllocation { get; set; } = new List<BudgetAllocation>();

    public virtual ICollection<BudgetMove> BudgetMoveFromCategory { get; set; } = new List<BudgetMove>();

    public virtual ICollection<BudgetMove> BudgetMoveToCategory { get; set; } = new List<BudgetMove>();

    public virtual CategoryGroup Group { get; set; } = null!;

    public virtual ICollection<Transaction> Transaction { get; set; } = new List<Transaction>();

    public virtual ICollection<TransactionSplit> TransactionSplit { get; set; } = new List<TransactionSplit>();
}
