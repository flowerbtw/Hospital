using System;
using System.Collections.Generic;

namespace Hospital.Database;

public partial class MedicalCard
{
    public string MedicalCardNumber { get; set; } = null!;

    public string? MedicalCardDateOfIssue { get; set; }
}
