using System;
using System.Collections.Generic;

namespace RepositoryLayer.Models;

public partial class Category
{
    public int CateId { get; set; }

    public string? CateName { get; set; }

    public virtual ICollection<Cafe> Cafes { get; set; } = new List<Cafe>();
}
