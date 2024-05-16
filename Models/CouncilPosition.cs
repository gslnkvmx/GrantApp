using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class CouncilPosition
{
    public string Id { get; set; } = null!;

    public string PositionName { get; set; } = null!;

    public int Value { get; set; }

    public virtual ICollection<KpCouncil> KpCouncils { get; set; } = new List<KpCouncil>();
}
