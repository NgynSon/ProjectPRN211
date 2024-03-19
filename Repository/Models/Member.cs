using System;
using System.Collections.Generic;

namespace RepositoryLayer.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string? MemberName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateTime? Date { get; set; }

    public string? Gender { get; set; }

    public string? Position { get; set; }

    public int? Role { get; set; }
}
