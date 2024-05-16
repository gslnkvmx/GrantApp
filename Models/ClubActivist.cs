using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class ClubActivist
{
    public int Id { get; set; }

    public int Student { get; set; }

    public string Club { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string Position { get; set; } = null!;

    public virtual Club ClubNavigation { get; set; } = null!;

    public virtual ClubActivistsPosition PositionNavigation { get; set; } = null!;

    public virtual Student StudentNavigation { get; set; } = null!;
}
