using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class Hsfi
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public virtual ICollection<Club> Clubs { get; set; } = new List<Club>();

    public virtual ICollection<Curator> Curators { get; set; } = new List<Curator>();

    public virtual ICollection<KpHsfi> KpHsfis { get; set; } = new List<KpHsfi>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<StudyGroup> StudyGroups { get; set; } = new List<StudyGroup>();
}
