using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class AssociationPosition
{
    public string Id { get; set; } = null!;

    public string PositionName { get; set; } = null!;

    public int Value { get; set; }

    public virtual ICollection<LeaderTeam> LeaderTeams { get; set; } = new List<LeaderTeam>();
}
