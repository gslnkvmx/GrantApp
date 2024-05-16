using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class GrantDTO
{
  public int Id { get; set; }

  public int? Amount { get; set; } = null!;
  public DateTime? Updated { get; set; }

  public decimal? Score { get; set; }

  public string? Full_Name { get; set; }
}
