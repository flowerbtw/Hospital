using System;
using System.Collections.Generic;

namespace Hospital.Database;

public partial class Hospitalization
{
    public long HospitalizationId { get; set; }

    public long? PatientId { get; set; }

    public string? HospitalizationDate { get; set; }

    public long? DoctorId { get; set; }

    public string? HospitalizationType { get; set; }

    public long? ProcedureId { get; set; }

    public string? Result { get; set; }

    public string? Recommendations { get; set; }

    public virtual Doctor? Doctor { get; set; }

    public virtual MedicalProcedure? Procedure { get; set; }
}
