using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class StudentDTO
{
  public int Id { get; set; }

  public string Last_Name { get; set; } = null!;

  public string First_Name { get; set; } = null!;

  public string? Middle_Name { get; set; }

  public string? Phone_Number { get; set; }

  public string? Vk { get; set; }

  public string Group_Name { get; set; } = null!;
}
