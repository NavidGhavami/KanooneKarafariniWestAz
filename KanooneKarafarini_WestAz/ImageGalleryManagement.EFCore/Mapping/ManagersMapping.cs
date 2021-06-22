using ImageGalleryManagement.Domain.Managers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImageGalleryManagement.EFCore.Mapping
{
    public class ManagersMapping : IEntityTypeConfiguration<Managers>
    {
        public void Configure(EntityTypeBuilder<Managers> builder)
        {
            builder.ToTable("Managers");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Fullname).IsRequired().HasMaxLength(350);
            builder.Property(x => x.JobPosition).IsRequired().HasMaxLength(350);
            builder.Property(x => x.OrganizationType).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Picture).IsRequired().HasMaxLength(10000);
            builder.Property(x => x.PictureAlt).IsRequired().HasMaxLength(10000);
            builder.Property(x => x.PictureTitle).IsRequired().HasMaxLength(10000);
            builder.Property(x => x.Email).HasMaxLength(450);
            builder.Property(x => x.Phone).HasMaxLength(80);
            builder.Property(x => x.Mobile).HasMaxLength(80);
        }
    }
}
