using EntrepreneurManagement.Domain.TrueEntrepreneur;
using EntrepreneurManagement.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace EntrepreneurManagement.Infrastructure.EFCore
{
    public class EntrepreneurContext : DbContext
    {
        public DbSet<TrueEntrepreneur> TrueEntrepreneurs { get; set; }


        public EntrepreneurContext(DbContextOptions<EntrepreneurContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(TrueEntrepreneurMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
