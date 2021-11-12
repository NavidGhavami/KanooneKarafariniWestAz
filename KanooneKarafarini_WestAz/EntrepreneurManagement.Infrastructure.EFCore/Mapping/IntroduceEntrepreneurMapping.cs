using EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceEntrepreneur;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrepreneurManagement.Infrastructure.EFCore.Mapping
{
    public class IntroduceEntrepreneurMapping : IEntityTypeConfiguration<IntroduceEntrepreneur>
    {
        public void Configure(EntityTypeBuilder<IntroduceEntrepreneur> builder)
        {
            builder.ToTable("IntroduceEntrepreneur");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.Fullname).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Job).IsRequired().HasMaxLength(150);
            builder.Property(x => x.StateTitle).IsRequired().HasMaxLength(100);
        }
    }
}
