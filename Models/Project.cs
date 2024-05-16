using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class Project
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string ProjectType { get; set; } = null!;

    public string? Hsfi { get; set; }

    public string? Association { get; set; }

    public string? Structure { get; set; }

    public virtual Association? AssociationNavigation { get; set; }

    public virtual Hsfi? HsfiNavigation { get; set; }

    public virtual ICollection<ProjectActivist> ProjectActivists { get; set; } = new List<ProjectActivist>();

    public virtual ProjectType ProjectTypeNavigation { get; set; } = null!;

    public virtual Structure? StructureNavigation { get; set; }
}
