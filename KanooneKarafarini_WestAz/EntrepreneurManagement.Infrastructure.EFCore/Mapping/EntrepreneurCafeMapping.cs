using EntrepreneurManagement.Domain.EntrepreneurServices.EntrepreneurCafe;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrepreneurManagement.Infrastructure.EFCore.Mapping
{
    public class EntrepreneurCafeMapping : IEntityTypeConfiguration<EntrepreneurCafe>
    {
        public void Configure(EntityTypeBuilder<EntrepreneurCafe> builder)
        {
            builder.ToTable("EntrepreneurCafe");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CafeName).IsRequired().HasMaxLength(550);
            builder.Property(x => x.CafeCity).IsRequired().HasMaxLength(550);
            builder.Property(x => x.CafeManager).IsRequired().HasMaxLength(250);
            builder.Property(x => x.CafeLeader).IsRequired().HasMaxLength(250);
            builder.Property(x => x.CafeManagerMobile).IsRequired().HasMaxLength(150);
            builder.Property(x => x.CafeLeaderMobile).IsRequired().HasMaxLength(150);
        }
    }
}
