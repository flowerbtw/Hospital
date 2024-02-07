using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Database;

public partial class HospitalContext : DbContext
{
    public HospitalContext()
    {
    }

    public HospitalContext(DbContextOptions<HospitalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Hospitalization> Hospitalizations { get; set; }

    public virtual DbSet<Insurance> Insurances { get; set; }

    public virtual DbSet<MedicalCard> MedicalCards { get; set; }

    public virtual DbSet<MedicalProcedure> MedicalProcedures { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source = E:\\Development\\Microsoft Visual Studio\\WordSkills 2024\\Hospital\\Hospital\\bin\\Debug\\net7.0-windows\\Hospital.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.Property(e => e.DoctorId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Hospitalization>(entity =>
        {
            entity.Property(e => e.HospitalizationId).ValueGeneratedNever();

            entity.HasOne(d => d.Doctor).WithMany(p => p.Hospitalizations).HasForeignKey(d => d.DoctorId);

            entity.HasOne(d => d.Procedure).WithMany(p => p.Hospitalizations).HasForeignKey(d => d.ProcedureId);
        });

        modelBuilder.Entity<Insurance>(entity =>
        {
            entity.HasKey(e => e.InsuranceNumber);

            entity.ToTable("Insurance");
        });

        modelBuilder.Entity<MedicalCard>(entity =>
        {
            entity.HasKey(e => e.MedicalCardNumber);
        });

        modelBuilder.Entity<MedicalProcedure>(entity =>
        {
            entity.HasKey(e => e.ProcedureId);

            entity.HasIndex(e => e.ProcedureName, "IX_MedicalProcedures_ProcedureName").IsUnique();

            entity.Property(e => e.ProcedureId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasIndex(e => e.Email, "IX_Patients_Email").IsUnique();

            entity.HasIndex(e => e.InsuranceNumber, "IX_Patients_InsuranceNumber").IsUnique();

            entity.HasIndex(e => e.MedicalCardNumber, "IX_Patients_MedicalCardNumber").IsUnique();

            entity.HasIndex(e => e.Passport, "IX_Patients_Passport").IsUnique();

            entity.HasIndex(e => e.PhoneNumber, "IX_Patients_PhoneNumber").IsUnique();

            entity.Property(e => e.PatientId).ValueGeneratedNever();

            entity.HasOne(d => d.InsuranceNumberNavigation).WithOne(p => p.Patient).HasForeignKey<Patient>(d => d.InsuranceNumber);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
