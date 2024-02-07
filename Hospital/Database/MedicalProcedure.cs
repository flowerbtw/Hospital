using System;
using System.Collections.Generic;

namespace Hospital.Database;

public partial class MedicalProcedure
{
    public long ProcedureId { get; set; }

    public string? ProcedureName { get; set; }

    public string? ProcedureType { get; set; }

    public long? Price { get; set; }

    public virtual ICollection<Hospitalization> Hospitalizations { get; set; } = new List<Hospitalization>();
}
