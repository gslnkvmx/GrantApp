using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class HistoryGroup
{
    public int Id { get; set; }

    public int Student { get; set; }

    public string StudyGroup { get; set; } = null!;

    public DateOnly RelevantFrom { get; set; }

    public DateOnly? RelevantTo { get; set; }

    public virtual Student StudentNavigation { get; set; } = null!;

    public virtual StudyGroup StudyGroupNavigation { get; set; } = null!;
}
