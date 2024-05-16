using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class ProjectPosition
{
    public string Id { get; set; } = null!;

    public string PositionName { get; set; } = null!;

    public int Value { get; set; }

    public virtual ICollection<ProjectActivist> ProjectActivists { get; set; } = new List<ProjectActivist>();
}
