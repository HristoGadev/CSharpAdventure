using HospitalDatabaseData.EntityConfiguration;
using HospitalDatabaseDataModels;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;

namespace HospitalDatabaseData
{
    public class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }
        public HospitalContext(DbContextOptions options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Visitation> Visitations { get; set; }
        public DbSet<PatientMedicament> PatientMedicaments { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConfigurationString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new PatientConfig());
            modelBuilder.ApplyConfiguration(new DiagnoseConfig());
            modelBuilder.ApplyConfiguration(new MedicamentConfig());
            modelBuilder.ApplyConfiguration(new VisitationConfig());
            modelBuilder.ApplyConfiguration(new PatientMedicamentConfig());
          

            modelBuilder.Entity<Medicament>().HasData(MedicamentGenerator.InitialMedicamentSeed(this));
        }
    }


}
