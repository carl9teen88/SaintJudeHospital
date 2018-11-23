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
    }
}
