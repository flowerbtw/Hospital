using System;
using System.Collections.Generic;

namespace Hospital.Database;

public partial class Insurance
{
    public string InsuranceNumber { get; set; } = null!;

    public string? InsuranceExpiringDate { get; set; }

    public virtual Patient? Patient { get; set; }
}
