using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class LeaderTeam
{
    public int Id { get; set; }

    public string Association { get; set; } = null!;

    public int Student { get; set; }

    public string Position { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public short MainYear { get; set; }

    public virtual Association AssociationNavigation { get; set; } = null!;

    public virtual AssociationPosition PositionNavigation { get; set; } = null!;

    public virtual Student StudentNavigation { get; set; } = null!;
}
