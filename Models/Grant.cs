using System;
using System.Collections.Generic;

namespace GrantApp.Models;

public partial class Grant
{
  public int Id { get; set; }

  public int? Amount { get; set; } = null!;
}
