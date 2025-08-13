using System;
using System.Collections.Generic;

namespace FinanceApp.Core.Data.Generated;

public partial class Account
{
    public int ID { get; set; }

    public string AccountName { get; set; } = null!;

    public byte AccountType { get; set; }

    public bool IsOnBudget { get; set; }

    public decimal OpeningBalance { get; set; }

    public virtual ICollection<Reconciliation> Reconciliation { get; set; } = new List<Reconciliation>();

    public virtual ICollection<Transaction> TransactionAccount { get; set; } = new List<Transaction>();

    public virtual ICollection<Transaction> TransactionTransferAccount { get; set; } = new List<Transaction>();
}
