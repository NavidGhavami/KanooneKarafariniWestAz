using ImageGalleryManagement.Domain.PictureGallery;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImageGalleryManagement.EFCore.Mapping
{
    public class PictureGalleryMapping : IEntityTypeConfiguration<PictureGallery>
    {
        public void Configure(EntityTypeBuilder<PictureGallery> builder)
        {
            builder.ToTable("PictureGallery");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Picture).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.PictureAlt).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.PictureTitle).HasMaxLength(1000).IsRequired();
        }
    }
}
