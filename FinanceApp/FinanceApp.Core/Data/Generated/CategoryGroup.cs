using System;
using System.Collections.Generic;

namespace FinanceApp.Core.Data.Generated;

public partial class CategoryGroup
{
    public int ID { get; set; }

    public string GroupName { get; set; } = null!;

    public int SortOrder { get; set; }

    public virtual ICollection<Category> Category { get; set; } = new List<Category>();
}
