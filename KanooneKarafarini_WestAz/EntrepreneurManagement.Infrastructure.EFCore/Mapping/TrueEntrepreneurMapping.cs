using EntrepreneurManagement.Domain.TrueEntrepreneur;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrepreneurManagement.Infrastructure.EFCore.Mapping
{
    public class TrueEntrepreneurMapping : IEntityTypeConfiguration<TrueEntrepreneur>
    {
        public void Configure(EntityTypeBuilder<TrueEntrepreneur> builder)
        {
            builder.ToTable("TrueEntrepreneurs");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Family).IsRequired().HasMaxLength(350);
            builder.Property(x => x.NationalId).IsRequired().HasMaxLength(20);
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.ActivitySubject).IsRequired().HasMaxLength(550);
            builder.Property(x => x.City).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Mobile).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Resume).IsRequired();
        }
    }
}
