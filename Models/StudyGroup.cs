using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class StudyGroup
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Hsfi { get; set; } = null!;

    public string Degree { get; set; } = null!;

    public short Graduation_Year { get; set; }

    public virtual Degree DegreeNavigation { get; set; } = null!;

    public virtual ICollection<HistoryGroup> HistoryGroups { get; set; } = new List<HistoryGroup>();

    public virtual Hsfi HsfiNavigation { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
