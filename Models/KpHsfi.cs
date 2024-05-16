using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class KpHsfi
{
    public int Id { get; set; }

    public int Student { get; set; }

    public string Hsfi { get; set; } = null!;

    public string Position { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public short MainYear { get; set; }

    public virtual Hsfi HsfiNavigation { get; set; } = null!;

    public virtual HsfiPosition PositionNavigation { get; set; } = null!;

    public virtual Student StudentNavigation { get; set; } = null!;
}
