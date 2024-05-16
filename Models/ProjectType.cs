using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class ProjectType
{
    public string Id { get; set; } = null!;

    public string Type { get; set; } = null!;

    public decimal Weight { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
