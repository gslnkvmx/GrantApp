using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class Curator
{
    public int Id { get; set; }

    public int Curator1 { get; set; }

    public string Hsfi { get; set; } = null!;

    public short Year { get; set; }

    public int Value { get; set; }

    public virtual Student Curator1Navigation { get; set; } = null!;

    public virtual Hsfi HsfiNavigation { get; set; } = null!;
}
