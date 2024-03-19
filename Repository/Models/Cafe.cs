using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RepositoryLayer.Models;

public partial class Cafe
{
    [Key]
    public int CaId { get; set; }

    public string? CafeName { get; set; }

    public int? CateId { get; set; }


    public string? Description { get; set; }

    public DateTime? ImportDate { get; set; }

    public int? Quantity { get; set; }

    public int? Price { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual Category? Cate { get; set; }
}
