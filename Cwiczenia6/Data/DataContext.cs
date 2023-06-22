using Cwiczenia6.Models;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia6.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Prescription_Medicament> Prescribed_Medicaments { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected DataContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>(e =>
            {
                e.HasKey(e => e.IdDoctor);
                e.Property(e => e.FirstName).HasMaxLength(100);
                e.Property(e => e.LastName).HasMaxLength(100);
                e.Property(e => e.Email).HasMaxLength(100);
            });
            modelBuilder.Entity<Patient>(e =>
            {
                e.HasKey(e => e.IdPatient);
                e.Property(e => e.FirstName).HasMaxLength(100);
                e.Property(e => e.LastName).HasMaxLength(100);
            });
            modelBuilder.Entity<Medicament>(e =>
            {
                e.HasKey(e => e.IdMedicament);
                e.Property(e => e.Name).HasMaxLength(100);
                e.Property(e => e.Type).HasMaxLength(100);
                e.Property(e => e.Description).HasMaxLength(100);
            });
            modelBuilder.Entity<Prescription>(e =>
            {
                e.HasKey(e => e.IdPrescription);

                 e.HasOne(e=> e.Doctor).WithMany(e => e.Prescriptions)
                .HasForeignKey(e => e.IdDoctor).OnDelete(DeleteBehavior.Cascade);
                
                e.HasOne(e=> e.Patient).WithMany(e => e.Prescriptions)
                .HasForeignKey(e => e.IdPatient).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Prescription_Medicament>(e =>
            {
                e.HasKey(e => new { e.IdMedicament, e.IdPrescription });

                e.Property(e=> e.Details).HasMaxLength(100);

                e.HasOne(e => e.Medicament).WithMany(e => e.Prescribed_Medications)
                .HasForeignKey(e => e.IdMedicament).OnDelete(DeleteBehavior.Cascade);

                e.HasOne(e => e.Prescription).WithMany(e => e.Prescribed_Medications)
                .HasForeignKey(e => e.IdPrescription).OnDelete(DeleteBehavior.Cascade);
            });
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>(e =>
            {
                e.HasData(new List<Doctor>()
                {
                    new Doctor
                    {
                        IdDoctor=1,
                        FirstName="Marek",
                        LastName="Tokarek",
                        Email="m.tokarek@lekarz.com"
                    }
                });
            });

            modelBuilder.Entity<Patient>(e =>
            {
                e.HasData(new List<Patient>()
                {
                    new Patient
                    {
                        IdPatient=1,
                        FirstName="Bogdan",
                        LastName="Boner",
                        Birthdate=DateTime.Now
                    }
                });
            });

            modelBuilder.Entity<Prescription>(e =>
            {
                e.HasData(new List<Prescription>()
                {
                    new Prescription
                    {
                        IdPrescription=1,
                        Date=DateTime.Now,
                        DueDate=DateTime.Now,
                        IdDoctor=1,
                        IdPatient=1
                    }
                });
            });
            
            modelBuilder.Entity<Medicament>(e =>
            {
                e.HasData(new List<Medicament>()
                {
                    new Medicament
                    {
                        IdMedicament=1,
                        Name="Paracetamol",
                        Type="Przeciwbólowe",
                        Description="Od niego przestaje bolec glowa"
                    }
                });
            });
            
            modelBuilder.Entity<Prescription_Medicament>(e =>
            {
                e.HasData(new List<Prescription_Medicament>()
                {
                    new Prescription_Medicament
                    {
                        IdMedicament=1,
                        IdPrescription=1,
                        Details="bierz az kopniesz w kalendarz"
                    }
                });
            });
        }
    }
}
