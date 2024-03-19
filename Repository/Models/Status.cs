using System;
using System.Collections.Generic;

namespace RepositoryLayer.Models;

public partial class Status
{
    public int StarusId { get; set; }

    public string? StatusName { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
