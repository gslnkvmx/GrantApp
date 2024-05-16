using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class Club
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Association { get; set; }

    public string? Hsfi { get; set; }

    public virtual Association? AssociationNavigation { get; set; }

    public virtual ICollection<ClubActivist> ClubActivists { get; set; } = new List<ClubActivist>();

    public virtual Hsfi? HsfiNavigation { get; set; }
}
