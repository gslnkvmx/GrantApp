using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class Rating
{
    public int Student { get; set; }

    public decimal Scores { get; set; }

    public bool Leads { get; set; }

    public virtual Student StudentNavigation { get; set; } = null!;
}
