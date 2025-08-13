using System;
using System.Collections.Generic;

namespace FinanceApp.Core.Data.Generated;

public partial class BudgetMove
{
    public int ID { get; set; }

    public int BudgetMonthId { get; set; }

    public int? FromCategoryId { get; set; }

    public int? ToCategoryId { get; set; }

    public decimal Amount { get; set; }

    public string? Memo { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual BudgetMonth BudgetMonth { get; set; } = null!;

    public virtual Category? FromCategory { get; set; }

    public virtual Category? ToCategory { get; set; }
}
