using Microsoft.EntityFrameworkCore;

namespace CGJ.Repository.Context
{
    public class CGJContext : DbContext
    {
        public CGJContext(DbContextOptions<CGJContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CGJContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
