using System;
using System.Collections.Generic;

namespace FinanceApp.Core.Data.Generated;

public partial class Payee
{
    public int ID { get; set; }

    public string PayeeName { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<Transaction> Transaction { get; set; } = new List<Transaction>();
}
