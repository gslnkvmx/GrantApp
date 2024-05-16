using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class Structure
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public decimal? Weight { get; set; }

    public virtual ICollection<Association> Associations { get; set; } = new List<Association>();

    public virtual ICollection<KpCouncil> KpCouncils { get; set; } = new List<KpCouncil>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
