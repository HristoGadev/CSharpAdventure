using CompanyModel;
using Microsoft.EntityFrameworkCore;

namespace CompanyData
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
        {
        }
        public CompanyContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConfigurationString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Employee>();
            entity.HasOne(m => m.Manager)
                .WithMany(e => e.ManagerEmployees)
                .HasForeignKey(m => m.ManagerId);
        }

    }
}
