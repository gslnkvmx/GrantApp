using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class ClubActivistsPosition
{
    public string Id { get; set; } = null!;

    public string PositionName { get; set; } = null!;

    public int Value { get; set; }

    public virtual ICollection<ClubActivist> ClubActivists { get; set; } = new List<ClubActivist>();
}
