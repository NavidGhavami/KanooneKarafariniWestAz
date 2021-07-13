using EntrepreneurManagement.Domain.EntrepreneurServices.CouncelingCenter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrepreneurManagement.Infrastructure.EFCore.Mapping
{
    public class CounselingCenterMapping : IEntityTypeConfiguration<CounselingCenter>
    {
        public void Configure(EntityTypeBuilder<CounselingCenter> builder)
        {
            builder.ToTable("CounselingCenter");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CouncelingCenterName).IsRequired().HasMaxLength(550);
            builder.Property(x => x.CouncelingCenterActivity).IsRequired().HasMaxLength(550);
            builder.Property(x => x.ManagerName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.CouncelingCenterPhone).IsRequired().HasMaxLength(150);
            builder.Property(x => x.CouncelingCenterMobile).IsRequired().HasMaxLength(150);
            builder.Property(x => x.CouncelingCenterAddress).IsRequired();
            builder.Property(x => x.CouncelingCenterName);
        }
    }
}
