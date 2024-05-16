using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class PersonalDatum
{
    public int Student { get; set; }

    public bool Exists { get; set; }

    public string SignedFrom { get; set; } = null!;

    public DateOnly SignedWhen { get; set; }

    public virtual Student StudentNavigation { get; set; } = null!;
}
