using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaintJudeHospital.Data.Indentity;
using SaintJudeHospital.Data.Seed;

namespace SaintJudeHospital.Data.Entity
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Symtom> Symtoms { set; get; }

        public DbSet<Parent> Parents { set; get; }

        public DbSet<Patient> Patients { set; get; }
       
        public DbSet<Inscription> Inscriptions { set; get; }

        public DbSet<Generic> Generics { set; get; }

        public DbSet<Medicine> Medicines { set; get; }
        
        public DbSet<Brand> Brands { set; get; }

        public DbSet<Vaccine> Vaccines { set; get; }
        
        public DbSet<VaccineType> VaccineTypes { set; get; }

        public DbSet<VaccinePatient> VaccinePatients { set; get; }

        public DbSet<Checkup> Checkups { set; get; }

        public DbSet<MedicalCertificate> MedicalCertificates { set; get; }

        public DbSet<PatientStatus> PatientStatuses { set; get; }

        public DbSet<Laboratory> Laboratories { set; get; }

        public DbSet<InPatient> InPatients { set; get; }

        public DbSet<Immunize> Immunizes { set; get; }

        public DbSet<Bill> Bills { set; get; }

        public DbSet<BillStatus> BillStatuses { set; get; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            AppDbContextInitializer.LoadDefaultData(builder);

            base.OnModelCreating(builder);
        }
    }
}
