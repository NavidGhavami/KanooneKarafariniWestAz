using EntrepreneurManagement.Domain.BenefactorEntrepreneur;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrepreneurManagement.Infrastructure.EFCore.Mapping
{
    public class BenefactorEntrepreneurMapping : IEntityTypeConfiguration<BenefactorEntrepreneur>
    {
        public void Configure(EntityTypeBuilder<BenefactorEntrepreneur> builder)
        {
            builder.ToTable("BenefactorEntrepreneur");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.BenefactorName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.BenefactorFamily).IsRequired().HasMaxLength(350);
            builder.Property(x => x.BenefactorNationalId).IsRequired().HasMaxLength(80);
            builder.Property(x => x.BenefactorJob).IsRequired().HasMaxLength(150);
            builder.Property(x => x.BenefactorCooperation).IsRequired().HasMaxLength(150);
            builder.Property(x => x.BenefactorPhone).IsRequired().HasMaxLength(150);
            builder.Property(x => x.BenefactorMobile).IsRequired().HasMaxLength(150);
            builder.Property(x => x.BenefactorAddress).IsRequired();
            builder.Property(x => x.CooperationDescription);
        }
    }
}
