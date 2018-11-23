using Microsoft.EntityFrameworkCore;

namespace SaintJudeHospital.Data.Entity
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { set; get; }

        public DbSet<Role> Roles { set; get; }

        public DbSet<Symtom> Symtoms { set; get; }

        public DbSet<Patient> Patients { set; get; }

        public DbSet<Parent> Parents { set; get; }

        public DbSet<Medicine> Medicines { set; get; }
        
        public DbSet<Brand> Brands { set; get; }

        public DbSet<Vaccine> Vaccines { set; get; }
        
        public DbSet<VaccineType> VaccineTypes { set; get; }

        public DbSet<VaccinePatient> VaccinePatients { set; get; }

        public DbSet<Checkup> Checkups { set; get; }

        public DbSet<MedicalCertificate> MedicalCertificates { set; get; }

        public DbSet<PatientStatus> PatientStatuses { set; get; }
    }
}
