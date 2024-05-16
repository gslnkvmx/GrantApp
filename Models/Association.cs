using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class Association
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string Structure { get; set; } = null!;

    public virtual ICollection<Club> Clubs { get; set; } = new List<Club>();

    public virtual ICollection<LeaderTeam> LeaderTeams { get; set; } = new List<LeaderTeam>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual Structure StructureNavigation { get; set; } = null!;
}
