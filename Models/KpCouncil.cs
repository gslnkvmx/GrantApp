using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class KpCouncil
{
    public int Id { get; set; }

    public string Position { get; set; } = null!;

    public int Student { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public short MainYear { get; set; }

    public string? Structure { get; set; }

    public virtual CouncilPosition PositionNavigation { get; set; } = null!;

    public virtual Structure? StructureNavigation { get; set; }

    public virtual Student StudentNavigation { get; set; } = null!;
}
