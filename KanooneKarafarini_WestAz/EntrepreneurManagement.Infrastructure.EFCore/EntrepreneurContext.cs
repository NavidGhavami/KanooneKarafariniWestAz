using System.Reflection.PortableExecutable;
using EntrepreneurManagement.Domain.BenefactorEntrepreneur;
using EntrepreneurManagement.Domain.EntrepreneurServices.CouncelingCenter;
using EntrepreneurManagement.Domain.EntrepreneurServices.EntrepreneurCafe;
using EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceArticle;
using EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceEntrepreneur;
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
        public DbSet<CounselingCenter> CounselingCenters { get; set; }
        public DbSet<EntrepreneurCafe> EntrepreneurCafes { get; set; }
        public DbSet<IntroduceEntrepreneur> IntroduceEntrepreneurs { get; set; }
        public DbSet<IntroduceArticle> IntroduceArticles { get; set; }

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
