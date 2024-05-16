using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Last_Name { get; set; } = null!;

    public string First_Name { get; set; } = null!;

    public string? Middle_Name { get; set; }

    public string? Phone_Number { get; set; }

    public string? Vk { get; set; }

    public string Study_Group { get; set; } = null!;

    public virtual ICollection<ClubActivist> ClubActivists { get; set; } = new List<ClubActivist>();

    public virtual ICollection<Curator> Curators { get; set; } = new List<Curator>();

    public virtual ICollection<HistoryGroup> HistoryGroups { get; set; } = new List<HistoryGroup>();

    public virtual ICollection<KpCouncil> KpCouncils { get; set; } = new List<KpCouncil>();

    public virtual ICollection<KpHsfi> KpHsfis { get; set; } = new List<KpHsfi>();

    public virtual ICollection<LeaderTeam> LeaderTeams { get; set; } = new List<LeaderTeam>();

    public virtual PersonalDatum? PersonalDatum { get; set; }

    public virtual ICollection<ProjectActivist> ProjectActivists { get; set; } = new List<ProjectActivist>();

    public virtual StudyGroup StudyGroupNavigation { get; set; } = null!;
}
