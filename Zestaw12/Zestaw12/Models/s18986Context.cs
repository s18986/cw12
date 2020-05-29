using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Zestaw12.Models
{
    public partial class s18986Context : DbContext
    {
        public s18986Context()
        {
        }

        public s18986Context(DbContextOptions<s18986Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Enrollment> Enrollment { get; set; }
        public virtual DbSet<Medicaments> Medicaments { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<PrescriptionMedicaments> PrescriptionMedicaments { get; set; }
        public virtual DbSet<Prescriptions> Prescriptions { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Studies> Studies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s18986;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => e.IdEnrollment)
                    .HasName("Enrollment_pk");

                entity.Property(e => e.IdEnrollment).ValueGeneratedNever();

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.IdStudyNavigation)
                    .WithMany(p => p.Enrollment)
                    .HasForeignKey(d => d.IdStudy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Enrollment_Studies");
            });

            modelBuilder.Entity<Medicaments>(entity =>
            {
                entity.HasKey(e => e.IdMedicament);
            });

            modelBuilder.Entity<Patients>(entity =>
            {
                entity.HasKey(e => e.IdPatient);
            });

            modelBuilder.Entity<PrescriptionMedicaments>(entity =>
            {
                entity.HasKey(e => e.IdPrescription);

                entity.ToTable("Prescription_Medicaments");

                entity.HasIndex(e => e.MedicamentIdMedicament);

                entity.HasIndex(e => e.PrescriptionIdPrescription);

                entity.HasOne(d => d.MedicamentIdMedicamentNavigation)
                    .WithMany(p => p.PrescriptionMedicaments)
                    .HasForeignKey(d => d.MedicamentIdMedicament);

                entity.HasOne(d => d.PrescriptionIdPrescriptionNavigation)
                    .WithMany(p => p.PrescriptionMedicaments)
                    .HasForeignKey(d => d.PrescriptionIdPrescription);
            });

            modelBuilder.Entity<Prescriptions>(entity =>
            {
                entity.HasKey(e => e.IdPrescription);

                entity.HasIndex(e => e.DoctorId);

                entity.HasIndex(e => e.PatientIdPatient);

                entity.Property(e => e.DateDue).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.DoctorId);

                entity.HasOne(d => d.PatientIdPatientNavigation)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.PatientIdPatient);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.IndexNumber)
                    .HasName("Student_pk");

                entity.Property(e => e.IndexNumber).HasMaxLength(100);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdEnrollmentNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.IdEnrollment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Student_Enrollment");
            });

            modelBuilder.Entity<Studies>(entity =>
            {
                entity.HasKey(e => e.IdStudy)
                    .HasName("Studies_pk");

                entity.Property(e => e.IdStudy).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
