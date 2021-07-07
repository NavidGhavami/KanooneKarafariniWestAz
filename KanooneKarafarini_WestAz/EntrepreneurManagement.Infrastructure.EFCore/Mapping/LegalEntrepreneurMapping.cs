using EntrepreneurManagement.Domain.LegalEntrepreneur;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrepreneurManagement.Infrastructure.EFCore.Mapping
{
    public class LegalEntrepreneurMapping : IEntityTypeConfiguration<LegalEntrepreneur>
    {
        public void Configure(EntityTypeBuilder<LegalEntrepreneur> builder)
        {
            builder.ToTable("LegalEntrepreneur");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Company).IsRequired().HasMaxLength(350);
            builder.Property(x => x.CompanyId).IsRequired().HasMaxLength(450);
            builder.Property(x => x.ManagerName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.ManagerFamily).IsRequired().HasMaxLength(250);
            builder.Property(x => x.ManagerNationalId).IsRequired().HasMaxLength(150);
            builder.Property(x => x.CompanySubject).IsRequired().HasMaxLength(450);
            builder.Property(x => x.CompanyCity).IsRequired().HasMaxLength(150);
            builder.Property(x => x.CompanyPhone).IsRequired().HasMaxLength(150);
            builder.Property(x => x.CompanyMobile).IsRequired().HasMaxLength(150);
            builder.Property(x => x.CompanyAddress).IsRequired();
            builder.Property(x => x.CompanyResume).IsRequired();
        }
    }
}
