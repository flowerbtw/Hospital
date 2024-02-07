using System;
using System.Collections.Generic;

namespace Hospital.Database;

public partial class Patient
{
    public long PatientId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Patronymic { get; set; }

    public string? Photo { get; set; }

    public string? Passport { get; set; }

    public string? Birthdate { get; set; }

    public string? Gender { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public long? House { get; set; }

    public long? Apartment { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? MedicalCardNumber { get; set; }

    public string? LastAppointment { get; set; }

    public string? NextAppointment { get; set; }

    public string? InsuranceNumber { get; set; }

    public string? Diagnosis { get; set; }

    public string? MedicalHistory { get; set; }

    public virtual Insurance? InsuranceNumberNavigation { get; set; }
}
