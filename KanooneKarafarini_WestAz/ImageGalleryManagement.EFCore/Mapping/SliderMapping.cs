using ImageGalleryManagement.Domain.Slider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopManagement.Infrastructure.EFCore.Mapping
{
    public class SliderMapping:IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.ToTable("Slider");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Picture).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.PictureAlt).HasMaxLength(10000).IsRequired();
            builder.Property(x => x.PictureTitle).HasMaxLength(10000).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(10000);

        }
    }
}
