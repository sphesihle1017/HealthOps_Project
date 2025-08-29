using HealthOps_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthOps_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // ======================
        // DbSets for all models
        // ======================
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Discharge> Discharges { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<NurseInstruction> NurseInstructions { get; set; }
        public DbSet<PatientMovement> PatientMovements { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<Visitation> Visitations { get; set; }
        public DbSet<VitalSign> VitalSigns { get; set; }
        public DbSet<HospitalStore> HospitalStores { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<StockManager> StockManager { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Consumable> Consumables { get; set; }
        public DbSet<ScriptManager> ScriptManagers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //     ======================
        //     Prevent Multiple Cascade Paths
        //     ======================

        //    modelBuilder.Entity<Admission>()
        //        .HasOne(a => a.Ward)
        //        .WithMany(w => w.Admissions)
        //        .HasForeignKey(a => a.WardId)
        //        .OnDelete(DeleteBehavior.Restrict); // Prevent cascade path

        //    modelBuilder.Entity<Admission>()
        //        .HasOne(a => a.Patient)
        //        .WithMany(p => p.Admissions)
        //        .HasForeignKey(a => a.PatientId)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder.Entity<Admission>()
        //        .HasOne(a => a.Bed)
        //        .WithMany(b => b.Admissions)
        //        .HasForeignKey(a => a.BedId)
        //        .OnDelete(DeleteBehavior.Restrict); // Prevent cascade path

        //    Ensure Order → OrderItems relationship works
        //    modelBuilder.Entity<OrderItem>()
        //        .HasOne(oi => oi.Order)
        //        .WithMany(o => o.OrderItems)
        //        .HasForeignKey(oi => oi.OrderId)
        //        .OnDelete(DeleteBehavior.Cascade);

        //Example: Prescription to Patient
        //    modelBuilder.Entity<Prescription>()
        //        .HasOne(p => p.Patient)
        //        .WithMany(pt => pt.Prescriptions)
        //        .HasForeignKey(p => p.PatientId)
        //        .OnDelete(DeleteBehavior.Cascade);

        //Example: Prescription to Doctor
        //    modelBuilder.Entity<Prescription>()
        //        .HasOne(p => p.Doctor)
        //        .WithMany(d => d.Prescriptions)
        //        .HasForeignKey(p => p.DoctorId)
        //        .OnDelete(DeleteBehavior.Restrict);
        //}
    }
}
