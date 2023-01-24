using Microsoft.EntityFrameworkCore;
namespace MarkelInternationAssignment.Model
{
    public class Claimsdbcontext : DbContext
    {
        public string DbPath { get; }
        public DbSet<Claim> claim { get; set; }

        public Claimsdbcontext(IConfiguration configuration)
        {
            DbPath = configuration.GetConnectionString("BloggingDatabase");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(DbPath);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Claim>(entity =>
            {
                entity.ToTable("Claim");
                entity.HasNoKey();                
                entity.Property(e => e.Closed).HasConversion(i => i != 0, e => e ? 1 : 0);
                
            });

               
                
            
        }

    }
}
