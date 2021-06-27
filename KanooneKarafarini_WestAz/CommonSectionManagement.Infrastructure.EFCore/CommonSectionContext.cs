using CommonSectionManagement.Domain.Footer;
using CommonSectionManagement.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CommonSectionManagement.Infrastructure.EFCore
{
    public class CommonSectionContext : DbContext
    {
        public DbSet<Footer> Footers { get; set; }
        




        public CommonSectionContext(DbContextOptions<CommonSectionContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(FooterMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
