using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class HsfiPosition
{
    public string Id { get; set; } = null!;

    public string PositionName { get; set; } = null!;

    public int Value { get; set; }

    public virtual ICollection<KpHsfi> KpHsfis { get; set; } = new List<KpHsfi>();
}
