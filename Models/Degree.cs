using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class Degree
{
    public string Id { get; set; } = null!;

    public string degree { get; set; } = null!;

    public virtual ICollection<StudyGroup> StudyGroups { get; set; } = new List<StudyGroup>();
}
