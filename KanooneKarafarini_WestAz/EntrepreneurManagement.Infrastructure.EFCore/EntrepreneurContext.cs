using EntrepreneurManagement.Domain.BenefactorEntrepreneur;
using EntrepreneurManagement.Domain.EntrepreneurServices.SubmitIdea;
using EntrepreneurManagement.Domain.LegalEntrepreneur;
using EntrepreneurManagement.Domain.RahyarEntrepreneur;
using EntrepreneurManagement.Domain.StudentEntrepreneur;
using EntrepreneurManagement.Domain.TrueEntrepreneur;
using EntrepreneurManagement.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace EntrepreneurManagement.Infrastructure.EFCore
{
    public class EntrepreneurContext : DbContext
    {
        public DbSet<TrueEntrepreneur> TrueEntrepreneurs { get; set; }
        public DbSet<LegalEntrepreneur> LegalEntrepreneurs { get; set; }
        public DbSet<StudentEntrepreneur> StudentEntrepreneurs { get; set; }
        public DbSet<RahyarEntrepreneur> RahyarEntrepreneurs { get; set; }
        public DbSet<BenefactorEntrepreneur> BenefactorEntrepreneurs { get; set; }
        public DbSet<SubmitIdea> SubmitIdeas { get; set; }


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
