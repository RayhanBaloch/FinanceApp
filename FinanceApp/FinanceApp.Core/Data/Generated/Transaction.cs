using System;
using System.Collections.Generic;

namespace FinanceApp.Core.Data.Generated;

public partial class Transaction
{
    public int ID { get; set; }

    public int AccountId { get; set; }

    public DateOnly TransactionDate { get; set; }

    public int? PayeeId { get; set; }

    public int? CategoryId { get; set; }

    public decimal Amount { get; set; }

    public string? Memo { get; set; }

    public bool Reconciled { get; set; }

    public int? TransferAccountId { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Category? Category { get; set; }

    public virtual Payee? Payee { get; set; }

    public virtual ICollection<TransactionSplit> TransactionSplit { get; set; } = new List<TransactionSplit>();

    public virtual Account? TransferAccount { get; set; }
}
