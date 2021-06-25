using ImageGalleryManagement.Domain.Partners;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImageGalleryManagement.EFCore.Mapping
{
    public class PartnersMapping : IEntityTypeConfiguration<Partners>
    {
        public void Configure(EntityTypeBuilder<Partners> builder)
        {
            builder.ToTable("Partners");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(550);
            builder.Property(x => x.Picture).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.PictureAlt).IsRequired().HasMaxLength(550);
            builder.Property(x => x.PictureTitle).IsRequired().HasMaxLength(550);
        }
    }
}
