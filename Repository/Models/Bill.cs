using System;
using System.Collections.Generic;

namespace RepositoryLayer.Models;

public partial class Bill
{
    public int BillId { get; set; }

    public int? CaId { get; set; }

    public int? TotalMoney { get; set; }
    public int? Quantity { get; set; }

    public int? Status { get; set; }

    public virtual Cafe? Cafe { get; set; }

    public virtual Status? StatusNavigation { get; set; }
}
