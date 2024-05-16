using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class ProjectActivist
{
    public int Id { get; set; }

    public int Student { get; set; }

    public string Project { get; set; } = null!;

    public string Position { get; set; } = null!;

    public short Year { get; set; }

    public virtual ProjectPosition PositionNavigation { get; set; } = null!;

    public virtual Project ProjectNavigation { get; set; } = null!;

    public virtual Student StudentNavigation { get; set; } = null!;
}
